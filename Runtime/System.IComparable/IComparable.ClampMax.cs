// smidgens @ github

#if !EXT_0_SYSTEM_ICOMPARABLE

namespace Smidgenomics.Unity.Extensions
{
	using System;

	public static partial class Comparable_
	{
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
	}
}

#endif