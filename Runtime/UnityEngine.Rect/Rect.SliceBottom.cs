// smidgens @ github

#if !EXT_0_UNITYENGINE_RECT

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;

	public static partial class Rect_
	{
		/// <summary>
		/// Slices a rect of height h from bottom and returns it.
		/// Note: changes original rect
		/// </summary>
		/// <param name="r">Rect</param>
		/// <param name="h">Slice height</param>
		/// <returns>Bottom slice</returns>
		public static Rect SliceBottom(this ref Rect r, in float h)
		{
			var r2 = r;
			r2.height = h;
			r.height -= h;
			r2.y += r.height;
			return r2;
		}
	}
}

#endif