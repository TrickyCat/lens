﻿using Lens.Compiler;

namespace Lens.SyntaxTree.Literals
{
	/// <summary>
	/// A node representing floating point double-precision literals.
	/// </summary>
	internal class DoubleNode : LiteralNodeBase<double>
	{
		public DoubleNode(double value = 0)
		{
			Value = value;
		}

		protected override void compile(Context ctx, bool mustReturn)
		{
			var gen = ctx.CurrentILGenerator;
			gen.EmitConstant(Value);
		}
	}
}
