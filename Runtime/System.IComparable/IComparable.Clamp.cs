// smidgens @ github

#if !EXT_0_SYSTEM_ICOMPARABLE

namespace Smidgenomics.Unity.Extensions
{
	using System;

	public static partial class Comparable_
	{
		/// <summary>
		/// Clamps comparable type to a given range [min,max]
		/// </summary>
		/// <typeparam name="T">Value</typeparam>
		/// <param name="value">Value</param>
		/// <param name="min">Minimum value</param>
		/// <param name="max">Maximum value</param>
		/// <returns>Value bounded between min and max</returns>
		public static T Clamp<T>(this T value, in T min, in T max)
		where T : struct, IComparable<T>
		{
			if (value.CompareTo(min) < 0) { return min; }
			if (value.CompareTo(max) > 0) { return max; }
			return value;
		}
	}
}

#endif