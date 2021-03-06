﻿using System.Collections.Generic;
using Lens.Compiler;

namespace Lens.SyntaxTree.Expressions
{
	/// <summary>
	/// A node representing assignment to an index.
	/// </summary>
	internal class SetIndexNode : IndexNodeBase
	{
		/// <summary>
		/// Value to be assigned.
		/// </summary>
		public NodeBase Value { get; set; }

		public override IEnumerable<NodeBase> GetChildNodes()
		{
			yield return Expression;
			yield return Index;
			yield return Value;
		}

		protected override void compile(Context ctx, bool mustReturn)
		{
			var exprType = Expression.GetExpressionType(ctx);

			if (exprType.IsArray)
				compileArray(ctx);
			else
				compileCustom(ctx);
		}

		private void compileArray(Context ctx)
		{
			var gen = ctx.CurrentILGenerator;

			var exprType = Expression.GetExpressionType(ctx);
			var itemType = exprType.GetElementType();

			Expression.Compile(ctx, true);
			Index.Compile(ctx, true);
			Value.Compile(ctx, true);
			gen.EmitSaveIndex(itemType);
		}

		private void compileCustom(Context ctx)
		{
			var gen = ctx.CurrentILGenerator;

			var exprType = Expression.GetExpressionType(ctx);
			var idxType = Index.GetExpressionType(ctx);

			try
			{
				var pty = ctx.ResolveIndexer(exprType, idxType, false);
				var idxDest = pty.ArgumentTypes[0];
				var valDest = pty.ArgumentTypes[1];

				Expression.Compile(ctx, true);

				Expr.Cast(Index, idxDest).Compile(ctx, true);
				Expr.Cast(Value, valDest).Compile(ctx, true);

				gen.EmitCall(pty.MethodInfo);
			}
			catch (LensCompilerException ex)
			{
				ex.BindToLocation(this);
				throw;
			}
		}

		#region Equality members

		protected bool Equals(SetIndexNode other)
		{
			return base.Equals(other) && Equals(Value, other.Value);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((SetIndexNode)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return (base.GetHashCode() * 397) ^ (Value != null ? Value.GetHashCode() : 0);
			}
		}

		#endregion

		public override string ToString()
		{
			return string.Format("setidx({0} of {1} = {2})", Index, Expression, Value);
		}
	}
}
