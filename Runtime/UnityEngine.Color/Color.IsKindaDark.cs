// smidgens @ github

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;

	public static partial class Color_
	{
		/// <summary>
		/// Checks if color value is dark-ish based on contrast
		/// </summary>
		/// <param name="v">Color</param>
		/// <returns>True if color is on the darker side</returns>
		public static bool IsKindaDark(this in Color v)
		{
			// https://24ways.org/2010/calculating-color-contrast
			var yiq = (v.r * 2126f + v.g * 7152f + v.b * 722f) / 10000f;
			return yiq < 128;
		}
	}
}