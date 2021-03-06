﻿using System;
using System.Collections.Generic;
using System.Linq;
using Lens.Compiler;

namespace Lens.SyntaxTree.ControlFlow
{
	/// <summary>
	/// An anonymous function definition node.
	/// </summary>
	internal abstract class FunctionNodeBase : NodeBase
	{
		protected FunctionNodeBase()
		{
			Arguments = new List<FunctionArgument>();
			Body = new CodeBlockNode();
		}

		/// <summary>
		/// Function arguments.
		/// </summary>
		public List<FunctionArgument> Arguments { get; set; }

		/// <summary>
		/// Function body.
		/// </summary>
		public CodeBlockNode Body { get; set; }

		protected override Type resolveExpressionType(Context ctx, bool mustReturn = true)
		{
			return Body.GetExpressionType(ctx);
		}

		public override IEnumerable<NodeBase> GetChildNodes()
		{
			yield return Body;
		}

		#region Equality members

		protected bool Equals(FunctionNodeBase other)
		{
			return Arguments.SequenceEqual(other.Arguments) && Equals(Body, other.Body);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((FunctionNodeBase)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return ((Arguments != null ? Arguments.GetHashCode() : 0) * 397) ^ (Body != null ? Body.GetHashCode() : 0);
			}
		}

		#endregion
	}
}
