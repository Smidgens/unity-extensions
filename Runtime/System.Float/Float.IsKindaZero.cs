// smidgens @ github

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;

	public static partial class Float_
	{
		/// <summary>
		/// Checks if value approximately equals 0
		/// </summary>
		/// <param name="v">Value</param>
		/// <returns>True if approx. zero</returns>
		public static bool IsKindaZero(this in float v) => Mathf.Approximately(0f, v);
	}
}