// smidgens @ github

namespace Smidgenomics.Unity.Extensions
{
	using System;

	public static class Comparable_
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

		/// <summary>
		/// Clamps comparable value to a given maximum
		/// </summary>
		/// <typeparam name="T">Value</typeparam>
		/// <param name="value">Value</param>
		/// <param name="max">Maximum value</param>
		/// <returns>Value bounded by max</returns>
		public static T ClampMax<T>(this T value, in T max)
		where T : struct, IComparable<T>
		{
			if (value.CompareTo(max) > 0) { return max; }
			return value;
		}

		/// <summary>
		/// Clamps comparable value to a given range [min,max] (inclusive)
		/// </summary>
		/// <typeparam name="T">Value</typeparam>
		/// <param name="value">Value</param>
		/// <param name="min">Minimum value</param>
		/// <param name="max">Maximum value</param>
		/// <returns>Value bounded between min and max</returns>
		public static T ClampRange<T>(this T value, in T min, in T max)
		where T : struct, IComparable<T>
		{
			if (value.CompareTo(min) < 0) { return min; }
			if (value.CompareTo(max) > 0) { return max; }
			return value;
		}
	}
}