﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Lens.Compiler;
using Lens.Lexer;
using Lens.Parser;
using Lens.SyntaxTree;

namespace Lens
{
	/// <summary>
	/// LENS main compiler class.
	/// https://github.com/impworks/lens
	/// </summary>
	public class LensCompiler : IDisposable
	{
		public LensCompiler(LensCompilerOptions opts = null)
		{
			m_Context = new Context(opts);
			Measurements = new Dictionary<string, TimeSpan>();
		}

		public void Dispose()
		{
			GlobalPropertyHelper.UnregisterContext(m_Context.ContextId);
		}

		public Dictionary<string, TimeSpan> Measurements;

		private Context m_Context;

		/// <summary>
		/// Register a type to be used by LENS script.
		/// </summary>
		public void RegisterType(Type type)
		{
			RegisterType(type != null ? type.Name : null, type);
		}

		/// <summary>
		/// Registers an aliased type to be used by LENS script.
		/// </summary>
		public void RegisterType(string alias, Type type)
		{
			if (type == null)
				throw new ArgumentNullException("type");

			m_Context.ImportType(alias, type);
		}

		/// <summary>
		/// Registers a method to be used by LENS script.
		/// </summary>
		public void RegisterFunction(string name, MethodInfo method)
		{
			m_Context.ImportFunction(name, method);
		}

		/// <summary>
		/// Registers a dynamic property to be used by LENS script.
		/// </summary>
		public void RegisterProperty<T>(string name, Func<T> getter, Action<T> setter = null)
		{
			m_Context.ImportProperty(name, getter, setter);
		}

		/// <summary>
		/// Compile the script for many invocations.
		/// </summary>
		public Func<object> Compile(string src)
		{
			try
			{
				var lexer = measure(() => new LensLexer(src), "Lexer");
				var parser = measure(() => new LensParser(lexer.Lexems), "Parser");
				var λ = measure(() => Compile(parser.Nodes), "Compiler");
				return λ;
			}
			catch (LensCompilerException)
			{
				throw;
			}
			catch (Exception ex)
			{
				throw new LensCompilerException(ex.Message);
			}
		}

		/// <summary>
		/// Compile the script for many invocations.
		/// </summary>
		internal Func<object> Compile(IEnumerable<NodeBase> nodes)
		{
			var script = m_Context.Compile(nodes);
			return script.Run;
		}

		/// <summary>
		/// Run the script and get a return value.
		/// </summary>
		public object Run(string src)
		{
			return Compile(src)();
		}

		/// <summary>
		/// Run the script and get a return value.
		/// </summary>
		internal object Run(IEnumerable<NodeBase> nodes)
		{
			return Compile(nodes)();
		}

		/// <summary>
		/// Prints out debug information about compilation stage timing if Options.DebugOutput flag is set.
		/// </summary>
		[DebuggerStepThrough]
		private T measure<T>(Func<T> action, string title)
		{
			var start = DateTime.Now;
			var res = action();
			var end = DateTime.Now;

			if (m_Context.Options.MeasureTime)
				Measurements[title] = end - start;

			return res;
		}
	}
}
