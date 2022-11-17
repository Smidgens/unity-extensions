// smidgens @ github

#if !EXT_0_UNITYENGINE_RECT

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;

	public static partial class Rect_
	{
		/// <summary>
		/// Slices a rect of same height and width from whichever dimension is smaller
		/// Note: changes original rect
		/// </summary>
		/// <param name="r">Rect</param>
		/// <param name="end">Slice from end (w > h ? right : bottom)</param>
		/// <returns>Square slice</returns>
		public static Rect SliceSquare(this ref Rect r, bool end = false)
		{
			if (r.width < r.height)
			{
				return !end ? r.SliceTop(r.width) : r.SliceBottom(r.width);
			}
			return !end ? r.SliceLeft(r.width) : r.SliceRight(r.width);
		}
	}
}

#endif