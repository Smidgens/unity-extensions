// smidgens @ github

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;

	public static partial class Rect_
	{
		
		/// <summary>
		/// Shifts position diagonally on both axes
		/// </summary>
		/// <param name="r">Rect</param>
		/// <param name="v">Shift by</param>
		public static void Shift(this ref Rect r, in float v) => r.Shift(v, v);

		/// <summary>
		/// Shifts position by x and y
		/// </summary>
		/// <param name="r">Rect</param>
		/// <param name="x">x shift</param>
		/// <param name="y">y shift</param>
		public static void Shift(this ref Rect r, in float x, in float y)
		{
			r.x += x;
			r.y += y;
		}
	}
}