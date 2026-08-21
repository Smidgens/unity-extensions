// smidgens @ github

namespace Smidgenomics.Unity.Extensions
{
	using System;

	public static partial class Float_
	{
		/// <summary>
		/// Rounds number by given decimal places
		/// </summary>
		/// <param name="v">Value</param>
		/// <param name="precision">Number of decimals</param>
		/// <returns>Rounded value</returns>
		public static float Round(this in float v, in byte precision)
		{
			return (float)Math.Round(v, precision);
		}
	}
}