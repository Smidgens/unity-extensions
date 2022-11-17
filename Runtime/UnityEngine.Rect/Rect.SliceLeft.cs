// smidgens @ github

#if !EXT_0_UNITYENGINE_RECT

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;

	public static partial class Rect_
	{
		/// <summary>
		/// Slices a rect of width w from left and returns it.
		/// Note: changes original rect
		/// </summary>
		/// <param name="r">Rect</param>
		/// <param name="w">Slice width</param>
		/// <returns>Left slice</returns>
		public static Rect SliceLeft(this ref Rect r, in float w)
		{
			var r2 = r;
			r2.width = w;
			r.width -= w;
			r.x += w;
			return r2;
		}
	}
}

#endif