﻿using System.Collections.Generic;
using System.Linq;

namespace Lens.SyntaxTree.Expressions
{
	/// <summary>
	/// A base class for various forms of method invocation that stores arguments.
	/// </summary>
	abstract internal class InvocationNodeBase : NodeBase
	{
		protected InvocationNodeBase()
		{
			Arguments = new List<NodeBase>();
		}

		/// <summary>
		/// The arguments of the invocation.
		/// </summary>
		public List<NodeBase> Arguments { get; set; }
	
		#region Equality members

		protected bool Equals(InvocationNodeBase other)
		{
			return Arguments.SequenceEqual(other.Arguments);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((InvocationNodeBase)obj);
		}

		public override int GetHashCode()
		{
			return (Arguments != null ? Arguments.GetHashCode() : 0);
		}

		#endregion
	}
}
