﻿namespace Lens.Lexer
{
	internal class StaticLexemDefinition
	{
		public readonly string Representation;

		public readonly LexemType Type;

		public StaticLexemDefinition(string repr, LexemType type)
		{
			Representation = repr;
			Type = type;
		}
	}
}
