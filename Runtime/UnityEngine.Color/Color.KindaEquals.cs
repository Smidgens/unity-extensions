// smidgens @ github

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;

	public static partial class Color_
	{
		/// <summary>
		/// Checks if color value is approximately equal to another
		/// Equivalent to checking Mathf.Approximately(c1,c2) for each channel in colors
		/// </summary>
		/// <param name="v">Color</param>
		/// <param name="other">Other Color</param>
		/// <param name="useAlpha">Should alpha channel be compared as well</param>
		/// <returns>True if colors are approx. equal</returns>
		public static bool KindaEquals(this in Color v, in Color other, bool useAlpha = true)
		{
			return
			Mathf.Approximately(v.r, other.r)
			&& Mathf.Approximately(v.g, other.g)
			&& Mathf.Approximately(v.b, other.b)
			&& (!useAlpha || Mathf.Approximately(v.a, other.a));
		}
	}
}