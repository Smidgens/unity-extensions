// smidgens @ github

#if !EXT_0_UNITYENGINE_VECTOR3

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;

	public static partial class Vector3_
	{
		/// <summary>
		/// Checks if value approximately equals other
		/// </summary>
		/// <param name="v">Vector3</param>
		/// <param name="other">Other Vector3</param>
		/// <returns>True if value approx. equals other</returns>
		public static bool KindaEquals(this in Vector3 v, in Vector3 other)
		{
			return
			Mathf.Approximately(v.x, other.x)
			&& Mathf.Approximately(v.y, other.y)
			&& Mathf.Approximately(v.z, other.z);
		}
	}
}

#endif