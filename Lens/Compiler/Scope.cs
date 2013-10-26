﻿using System;
using System.Collections.Generic;
using Lens.Translations;

namespace Lens.Compiler
{
	/// <summary>
	/// The scope information of a specific method.
	/// </summary>
	internal class Scope
	{
		public Scope()
		{
			Names = new Dictionary<string, LocalName>();
		}

		/// <summary>
		/// A scope that contains current scope;
		/// </summary>
		public Scope OuterScope;

		/// <summary>
		/// The lookup table of names defined in current scope.
		/// </summary>
		public Dictionary<string, LocalName> Names;

		/// <summary>
		/// The name of the closure class.
		/// </summary>
		public TypeEntity ClosureType { get; private set; }

		/// <summary>
		/// The ID for the type closured in current scope.
		/// </summary>
		public int? ClosureTypeId { get; private set; }

		/// <summary>
		/// The local variable ID that stores a pointer to current closure object.
		/// </summary>
		public LocalName ClosureVariable { get; private set; }

		#region Methods

		/// <summary>
		/// Register arguments as local variables.
		/// </summary>
		public void InitializeScope(Context ctx)
		{
			var method = ctx.CurrentMethod;
			if (method.Arguments == null)
				return;

			for(var idx = 0; idx < method.Arguments.Count; idx++)
			{
				var arg = method.Arguments[idx];
				var name = DeclareName(arg.Name, arg.Type ?? ctx.ResolveType(arg.TypeSignature), false, arg.IsRefArgument);
				name.ArgumentId = method.IsStatic ? idx : idx + 1;
			}
		}

		/// <summary>
		/// Gets information about a local name.
		/// </summary>
		public LocalName FindName(string name)
		{
			LocalName local = null;
			find(name, (loc, idx) => local = loc.GetClosuredCopy(idx));
			return local;
		}

		/// <summary>
		/// Declares a new name in the current scope.
		/// </summary>
		public LocalName DeclareName(string name, Type type, bool isConst, bool isRefArg = false)
		{
			if(find(name))
				throw new LensCompilerException(string.Format(CompilerMessages.VariableDefined, name));

			var n = new LocalName(name, type, isConst, isRefArg);
			Names[name] = n;
			return n;
		}

		/// <summary>
		/// Declares a new variable with autogenerated name.
		/// This name cannot be closured.
		/// </summary>
		public LocalName DeclareImplicitName(Context ctx, Type type, bool isConst)
		{
			var lb = ctx.CurrentILGenerator.DeclareLocal(type);
			var name = string.Format(EntityNames.ImplicitVariableNameTemplate, lb.LocalIndex);
			var ln = new LocalName(name, type, isConst) { LocalBuilder = lb };
			Names[name] = ln;
			return ln;
		}

		/// <summary>
		/// Declares a new temp variable that is instantly initialized.
		/// </summary>
		public LocalName DeclareInternalName(string name, Context ctx, Type type, bool isConst)
		{
			var lb = ctx.CurrentILGenerator.DeclareLocal(type);
			var ln = new LocalName(name, type, isConst) { LocalBuilder = lb };
			Names[name] = ln;
			return ln;
		}

		/// <summary>
		/// Checks if the variable is being referenced in another scope.
		/// </summary>
		public void ReferenceName(string name)
		{
			var found = find(
				name,
				(loc, idx) =>
				{
					var closured = idx > 0;
					if (closured)
					{
						if (loc.LocalBuilder != null)
							throw new InvalidOperationException(CompilerMessages.ClosureImplicit);

						if(loc.IsRefArgument)
							throw new LensCompilerException(CompilerMessages.ClosureRef);
					}

					loc.IsClosured |= closured;
				}
			);

			if(!found)
				throw new LensCompilerException(string.Format(CompilerMessages.VariableNotFound, name));
		}

		/// <summary>
		/// Creates a closure type for current closure.
		/// </summary>
		public TypeEntity CreateClosureType(Context ctx)
		{
			var id = ctx.GetClosureId();
			var closureName = string.Format(EntityNames.ClosureTypeNameTemplate, id);
			ClosureTypeId = id;
			ClosureType = ctx.CreateType(closureName, isSealed: true, prepare: true);
			ClosureType.Kind = TypeEntityKind.Closure;
			return ClosureType;
		}

		/// <summary>
		/// Creates a closured method in the current scope's closure type using function argument records.
		/// </summary>
		public MethodEntity CreateClosureMethod(Context ctx, IEnumerable<FunctionArgument> args, TypeSignature returnType = null)
		{
			return createClosureMethodInternal(ctx, name => ClosureType.CreateMethod(name, returnType ?? "Unit", args));
		}

		/// <summary>
		/// Creates a closured method in the current scope's closure type using argument types.
		/// </summary>
		public MethodEntity CreateClosureMethod(Context ctx, Type[] args, Type returnType = null)
		{
			return createClosureMethodInternal(ctx, name => ClosureType.CreateMethod(name, returnType ?? typeof(Unit), args));
		}

		/// <summary>
		/// Creates a closured method in the current scope's closure type.
		/// </summary>
		public MethodEntity createClosureMethodInternal(Context ctx, Func<string, MethodEntity> creator)
		{
			if (ClosureType == null)
				ClosureType = CreateClosureType(ctx);

			var closureName = string.Format(EntityNames.ClosureMethodNameTemplate, ClosureType.ClosureMethodId);
			ClosureType.ClosureMethodId++;

			var method = creator(closureName);
			method.Scope.OuterScope = this;
			return method;
		}

		/// <summary>
		/// Registers closure entities and assigns IDs to variables.
		/// </summary>
		public void FinalizeScope(Context ctx)
		{
			foreach (var curr in Names.Values)
			{
				if (curr.IsConstant && curr.IsImmutable && ctx.Options.UnrollConstants)
					continue;

				if (curr.IsClosured)
				{
					// create a field in the closured class
					var name = string.Format(EntityNames.ClosureFieldNameTemplate, curr.Name);
					curr.ClosureFieldName = name;
					ClosureType.CreateField(name, curr.Type);
				}
				else
				{
					curr.LocalBuilder = ctx.CurrentILGenerator.DeclareLocal(curr.Type);
				}
			}

			// create a field for base scope in the current type
			if(OuterScope != null && ClosureType != null)
				ClosureType.CreateField(EntityNames.ParentScopeFieldName, OuterScope.ClosureType.TypeBuilder);

			// register a variable for closure instance in the scope
			if (ClosureType != null)
				ClosureVariable = DeclareInternalName(string.Format(EntityNames.ClosureInstanceVariableNameTemplate, ClosureTypeId), ctx, ClosureType.TypeBuilder, false);
		}

		/// <summary>
		/// Finds a local name and invoke a callback.
		/// </summary>
		private bool find(string name, Action<LocalName, int> action = null)
		{
			var idx = 0;
			var scope = this;
			while (scope != null)
			{
				LocalName loc;
				if (scope.Names.TryGetValue(name, out loc))
				{
					if(action != null)
						action(loc, idx);
					return true;
				}

				idx++;
				scope = scope.OuterScope;
			}

			return false;
		}

		#endregion
	}
}
