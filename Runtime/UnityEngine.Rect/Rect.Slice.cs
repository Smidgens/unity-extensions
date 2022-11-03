// smidgens @ github

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;

	public static partial class Rect_
	{
		/// <summary>
		/// Slices a rect of height h from top and returns it.
		/// Note: changes original rect
		/// </summary>
		/// <param name="r">Rect</param>
		/// <param name="h">Slice height</param>
		/// <returns>Top slice</returns>
		public static Rect SliceTop(this ref Rect r, in float h)
		{
			var r2 = r;
			r2.height = h;
			r.height -= h;
			r.position += new Vector2(0f, h);
			return r2;
		}

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

		/// <summary>
		/// Slices a rect of width w from right and returns it.
		/// Note: changes original rect
		/// </summary>
		/// <param name="r">Rect</param>
		/// <param name="w">Slice width</param>
		/// <returns>Right slice</returns>
		public static Rect SliceRight(this ref Rect r, in float w)
		{
			var r2 = r;
			r2.width = w;
			r.width -= w;
			r2.x += r.width;
			return r2;
		}

		/// <summary>
		/// Slices a rect of same height and width from whichever side is smaller
		/// Note: changes original rect
		/// </summary>
		/// <param name="r">Rect</param>
		/// <param name="end">Slice from end</param>
		/// <returns>Square slice</returns>
		public static Rect SliceMinSquare(this ref Rect r, bool end = false)
		{
			if (r.width < r.height)
			{
				return !end ? r.SliceTop(r.width) : r.SliceBottom(r.width);
			}
			return !end ? r.SliceLeft(r.width) : r.SliceRight(r.width);
		}
	}
}
