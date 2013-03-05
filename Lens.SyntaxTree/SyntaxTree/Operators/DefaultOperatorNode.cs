﻿using System;
using System.Linq;
using Lens.SyntaxTree.Compiler;

namespace Lens.SyntaxTree.SyntaxTree.Operators
{
	/// <summary>
	/// A node representing the operator that returns a default value for the type.
	/// </summary>
	public class DefaultOperatorNode : TypeOperatorNodeBase, IPointerProvider
	{
		public bool PointerRequired { get; set; }

		/// <summary>
		/// Types that are equal to i4.0 in bytecode (according to C# compiler)
		/// </summary>
		private static readonly Type[] I4Types = new[]
		{
			typeof (bool),
			typeof (byte),
			typeof (sbyte),
			typeof (short),
			typeof (ushort),
			typeof (int),
			typeof (uint)
		};

		public DefaultOperatorNode(string type = null)
		{
			TypeSignature = type;
		}

		protected override Type resolveExpressionType(Context ctx, bool mustReturn = true)
		{
			return ctx.ResolveType(TypeSignature.Signature);
		}

		public override void Compile(Context ctx, bool mustReturn)
		{
			var gen = ctx.CurrentILGenerator;
			var type = GetExpressionType(ctx);

			if (I4Types.Contains(type))
				gen.EmitConstant(0);

			else if(type == typeof(long) || type == typeof(ulong))
				gen.EmitConstant(0L);

			else if(type == typeof(float))
				gen.EmitConstant(0.0f);

			else if(type == typeof(double))
				gen.EmitConstant(0.0);

			else if (type == typeof (decimal))
			{
				gen.EmitConstant(0);
				gen.EmitCreateObject(typeof(decimal).GetConstructor(new [] { typeof(int) }));
			}

			else if (!type.IsValueType)
				gen.EmitNull();

			else
			{
				var tmpVar = ctx.CurrentScope.DeclareImplicitName(ctx, GetExpressionType(ctx), true);

				gen.EmitLoadLocal(tmpVar, true);
				gen.EmitInitObject(type);

				gen.EmitLoadLocal(tmpVar, PointerRequired);
			}
		}

		public override string ToString()
		{
			return string.Format("default({0})", TypeSignature);
		}
	}
}
