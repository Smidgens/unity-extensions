// smidgens @ github

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;

	public static partial class Color_
	{
		/// <summary>
		/// Checks if color value is dark-ish
		/// </summary>
		/// <param name="v">Color</param>
		/// <returns>True if color is dark</returns>
		public static bool IsDark(this in Color v)
		{
			// https://24ways.org/2010/calculating-color-contrast
			var yiq = (v.r * 2126f + v.g * 7152f + v.b * 722f) / 10000f;
			return yiq < 128;
		}
	}
}