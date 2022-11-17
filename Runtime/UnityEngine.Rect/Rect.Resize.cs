// smidgens @ github

#if !EXT_0_UNITYENGINE_RECT

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;

	public static partial class Rect_
	{

		/// <summary>
		/// Resizes a given rect from its center
		/// </summary>
		/// <param name="r">Rect</param>
		/// <param name="s">Resize by</param>
		public static void Resize(this ref Rect r, in float s) => r.Resize(s, s, s, s);

		/// <summary>
		/// Resizes a given rect from its center
		/// </summary>
		/// <param name="r">Rect</param>
		/// <param name="lr">Left/right</param>
		/// <param name="tb">Top/bottom</param>
		public static void Resize(this ref Rect r, float lr, in float tb) => r.Resize(lr, lr, tb, tb);

		/// <summary>
		/// Resizes a given rect from its center
		/// </summary>
		/// <param name="rect">Rect</param>
		/// <param name="l"></param>
		/// <param name="r">Right</param>
		/// <param name="t">Top</param>
		/// <param name="b">Bottom</param>
		public static void Resize
		(
			this ref Rect rect,
			in float l,
			in float r,
			in float t,
			in float b
		)
		{
			var c = rect.center;
			rect.width += l + r;
			rect.height += t + b;
			rect.center = c;
		}
	}
}

#endif