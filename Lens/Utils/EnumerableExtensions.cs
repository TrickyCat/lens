﻿using System.Collections.Generic;
using System.Linq;

namespace Lens.Utils
{
	internal static class EnumerableExtensions
	{
		public static bool IsAnyOf<T>(this T obj, params T[] list)
		{
			for (var idx = list.Length - 1; idx >= 0; idx--)
				if (list[idx].Equals(obj))
					return true;

			return false;
		}

		public static bool IsEmpty<T>(this IEnumerable<T> seq)
		{
			return seq == null || !seq.Any();
		}
	}
}
