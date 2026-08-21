// smidgens @ github

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;

	public static partial class Rect_
	{
		public static Rect Padded(this Rect r, RectOffset ro)
		{
			var center = r.center;
			r.height -= ro.bottom + ro.top;
			r.width -= ro.left + ro.right;
			r.center = center;
			return r;
		}
	}
}