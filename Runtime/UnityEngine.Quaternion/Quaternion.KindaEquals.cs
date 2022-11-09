// smidgens @ github

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;

	internal static partial class Quaternion_
	{
		/// <summary>
		/// Checks if given quaternion approximately equals other in value
		/// </summary>
		/// <param name="r">Quaternion</param>
		/// <param name="other">Other Quaternion</param>
		/// <param name="acceptableRange">Margin considered "equal"</param>
		/// <returns></returns>
		public static bool KindaEquals
		(
			this in Quaternion r,
			in Quaternion other,
			in float acceptableRange = 0.0000004f
			)
		{
			return 1f - Mathf.Abs(Quaternion.Dot(r, other)) < acceptableRange;
		}
	}
}
