// smidgens @ github

#if !EXT_0_UNITYENGINE_COLOR

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;

	public static partial class Color_
	{
		/// <summary>
		/// Checks if color value is approximately equal to another
		/// </summary>
		/// <param name="v">Color</param>
		/// <param name="other">Other Color</param>
		/// <returns>True if colors are approx. equal</returns>
		public static bool KindaEquals(this in Color v, in Color other)
		{
			return
			Mathf.Approximately(v.r, other.r)
			&& Mathf.Approximately(v.g, other.g)
			&& Mathf.Approximately(v.b, other.b)
			&& Mathf.Approximately(v.a, other.a);
		}
	}
}

#endif