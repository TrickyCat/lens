﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lens.SyntaxTree.Compiler;
using Lens.SyntaxTree.SyntaxTree.ControlFlow;
using Lens.SyntaxTree.SyntaxTree.Expressions;
using Lens.SyntaxTree.SyntaxTree.Literals;
using Lens.SyntaxTree.SyntaxTree.Operators;

namespace Lens.SyntaxTree.SyntaxTree
{
	public static class Expr
	{
		#region Constants
		
		public static IntNode Int(int value = 0)
		{
			return new IntNode {Value = value};
		}

		public static DoubleNode Double(double value = 0)
		{
			return new DoubleNode(value);
		}

		public static BooleanNode Bool(bool value = false)
		{
			return new BooleanNode(value);
		}

		public static StringNode String(string value = null)
		{
			return new StringNode(value ?? string.Empty);
		}

		public static NullNode Null()
		{
			return new NullNode();
		}

		public static UnitNode Unit()
		{
			return new UnitNode();
		}

		#endregion

		#region Operators

		public static AddOperatorNode Add(NodeBase left, NodeBase right)
		{
			return Op<AddOperatorNode>(left, right);
		}

		public static SubtractOperatorNode Sub(NodeBase left, NodeBase right)
		{
			return Op<SubtractOperatorNode>(left, right);
		}

		public static MultiplyOperatorNode Mult(NodeBase left, NodeBase right)
		{
			return Op<MultiplyOperatorNode>(left, right);
		}

		public static DivideOperatorNode Div(NodeBase left, NodeBase right)
		{
			return Op<DivideOperatorNode>(left, right);
		}

		public static RemainderOperatorNode Remainder(NodeBase left, NodeBase right)
		{
			return Op<RemainderOperatorNode>(left, right);
		}

		public static PowOperatorNode Pow(NodeBase left, NodeBase right)
		{
			return Op<PowOperatorNode>(left, right);
		}

		public static InversionOperatorNode Inverse(NodeBase node)
		{
			return new InversionOperatorNode {Operand = node};
		}

		public static NegationOperatorNode Negate(NodeBase node)
		{
			return new NegationOperatorNode {Operand = node};
		}

		public static DefaultOperatorNode Default(TypeSignature type)
		{
			return new DefaultOperatorNode {Type = type};
		}

		public static TypeofOperatorNode Typeof(TypeSignature type)
		{
			return new TypeofOperatorNode {Type = type};
		}

		public static CastOperatorNode Cast(NodeBase node, TypeSignature type)
		{
			return new CastOperatorNode {Expression = node, TypeSignature = type};
		}

		public static CastOperatorNode Cast(NodeBase node, Type type)
		{
			return new CastOperatorNode { Expression = node, Type = type };
		}

		public static BinaryOperatorNodeBase And(NodeBase left, NodeBase right)
		{
			return new BooleanOperatorNode {LeftOperand = left, RightOperand = right};
		}

		public static BinaryOperatorNodeBase Or(NodeBase left, NodeBase right)
		{
			return new BooleanOperatorNode { Kind = BooleanOperatorKind.Or, LeftOperand = left, RightOperand = right };
		}

		public static BinaryOperatorNodeBase Xor(NodeBase left, NodeBase right)
		{
			return new BooleanOperatorNode { Kind = BooleanOperatorKind.Xor, LeftOperand = left, RightOperand = right };
		}

		public static ComparisonOperatorNode Equal(NodeBase left, NodeBase right)
		{
			return new ComparisonOperatorNode {LeftOperand = left, RightOperand = right};
		}

		public static ComparisonOperatorNode NotEqual(NodeBase left, NodeBase right)
		{
			return new ComparisonOperatorNode { Kind = ComparisonOperatorKind.NotEquals, LeftOperand = left, RightOperand = right };
		}

		public static ComparisonOperatorNode Less(NodeBase left, NodeBase right)
		{
			return new ComparisonOperatorNode { Kind = ComparisonOperatorKind.Less, LeftOperand = left, RightOperand = right };
		}

		public static ComparisonOperatorNode LessEqual(NodeBase left, NodeBase right)
		{
			return new ComparisonOperatorNode { Kind = ComparisonOperatorKind.LessEquals, LeftOperand = left, RightOperand = right };
		}

		public static ComparisonOperatorNode Greater(NodeBase left, NodeBase right)
		{
			return new ComparisonOperatorNode { Kind = ComparisonOperatorKind.Greater, LeftOperand = left, RightOperand = right };
		}

		public static ComparisonOperatorNode GreaterEqual(NodeBase left, NodeBase right)
		{
			return new ComparisonOperatorNode { Kind = ComparisonOperatorKind.GreaterEquals, LeftOperand = left, RightOperand = right };
		}

		private static T Op<T>(NodeBase left, NodeBase right) where T : BinaryOperatorNodeBase, new()
		{
			return new T {LeftOperand = left, RightOperand = right};
		}

		#endregion

		#region Initializers

		public static NewArrayNode Array(params NodeBase[] items)
		{
			return new NewArrayNode {Expressions = items.ToList()};
		}

		public static NewTupleNode Tuple(params NodeBase[] items)
		{
			return new NewTupleNode { Expressions = items.ToList() };
		}

		public static NewListNode List(params NodeBase[] items)
		{
			return new NewListNode { Expressions = items.ToList() };
		}

		public static NewObjectNode NewObject(TypeSignature type, params NodeBase[] args)
		{
			return new NewObjectNode {Type = type, Arguments = args.ToList()};
		}

		#endregion

		#region Expressions

		public static GetIndexNode GetIndex(NodeBase expr, NodeBase index)
		{
			return new GetIndexNode {Expression = expr, Index = index};
		}

		public static SetIndexNode SetIndex(NodeBase expr, NodeBase index, NodeBase value)
		{
			return new SetIndexNode { Expression = expr, Index = index, Value = value};
		}

		public static GetIdentifierNode GetIdentifier(string name)
		{
			return new GetIdentifierNode { Identifier = name };
		}

		public static SetIdentifierNode SetIdentifier(string name, NodeBase value)
		{
			return new SetIdentifierNode { Identifier = name, Value = value };
		}

		public static GetMemberNode GetMember(NodeBase expr, string name)
		{
			return new GetMemberNode { Expression = expr, MemberName = name };
		}

		public static GetMemberNode GetMember(TypeSignature type, string name)
		{
			return new GetMemberNode { StaticType = type, MemberName = name };
		}

		public static SetMemberNode SetMember(NodeBase expr, string name, NodeBase value)
		{
			return new SetMemberNode { Expression = expr, MemberName = name, Value = value };
		}

		public static SetMemberNode SetMember(TypeSignature type, string name, NodeBase value)
		{
			return new SetMemberNode { StaticType = type, MemberName = name, Value = value };
		}

		public static InvocationNode Invoke(string name, params NodeBase[] args)
		{

			return invoke(GetIdentifier(name), args);
		}

		public static InvocationNode Invoke(TypeSignature type, string name, params NodeBase[] args)
		{
			return Invoke(GetMember(type, name), args);
		}

		public static InvocationNode Invoke(NodeBase expr, string name, params NodeBase[] args)
		{
			return Invoke(GetMember(expr, name), args);
		}

		public static InvocationNode Invoke(NodeBase expr, params NodeBase[] args)
		{
			return invoke(expr, args);
		}

		private static InvocationNode invoke(NodeBase expr, params NodeBase[] args)
		{
			return new InvocationNode
			{
				Expression = expr,
				Arguments = args.Length == 0 ? new List<NodeBase> { Unit() } : args.ToList()
			};
		}

		#endregion

		#region Control Structures

		public static CodeBlockNode Block(params NodeBase[] stmts)
		{
			return new CodeBlockNode {Statements = stmts.ToList()};
		}

		public static VarNode Var(string name, NodeBase expr)
		{
			return new VarNode(name) {Value = expr};
		}

		public static LetNode Let(string name, NodeBase expr)
		{
			return new LetNode(name) { Value = expr };
		}

		public static LoopNode Loop(NodeBase condition, CodeBlockNode body)
		{
			return new LoopNode {Condition = condition, Body = body};
		}

		public static ConditionNode If(NodeBase condition, CodeBlockNode ifTrue, CodeBlockNode ifFalse = null)
		{
			return new ConditionNode {Condition = condition, TrueAction = ifTrue, FalseAction = ifFalse};
		}

		public static ThrowNode Throw(NodeBase expr)
		{
			return new ThrowNode {Expression = expr};
		}

		public static ThrowNode Throw(TypeSignature type, params NodeBase[] args)
		{
			return new ThrowNode { Expression = NewObject(type, args) };
		}

		public static TryNode Try(CodeBlockNode body, params CatchNode[] catches)
		{
			return new TryNode {Code = body, CatchClauses = catches.ToList()};
		}

		public static CatchNode Catch(TypeSignature excType, string varName, CodeBlockNode body)
		{
			return new CatchNode {Code = body, ExceptionType = excType, ExceptionVariable = varName};
		}

		public static CatchNode Catch(TypeSignature excType, CodeBlockNode body)
		{
			return new CatchNode { Code = body, ExceptionType = excType };
		}

		public static CatchNode CatchAll(CodeBlockNode body)
		{
			return new CatchNode { Code = body };
		}

		#endregion
	}
}