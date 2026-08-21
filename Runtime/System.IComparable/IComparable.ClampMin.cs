// smidgens @ github

namespace Smidgenomics.Unity.Extensions
{
	using System;

	public static partial class Comparable_
	{
		/// <summary>
		/// Clamps comparable value to a given minimum
		/// </summary>
		/// <typeparam name="T">Value</typeparam>
		/// <param name="value">Value</param>
		/// <param name="min">Minimum value</param>
		/// <returns>Value bounded by min</returns>
		public static T ClampMin<T>(this T value, in T min)
		where T : struct, IComparable<T>
		{
			if (value.CompareTo(min) < 0) { return min; }
			return value;
		}
	}
}