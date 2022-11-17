// smidgens @ github

#if !EXT_0_UNITYENGINE_VECTOR4

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;

	public static partial class Vector4_
	{
		/// <summary>
		/// Checks if value approximately equals other
		/// </summary>
		/// <param name="v">Vector4</param>
		/// <param name="other">Other Vector4</param>
		/// <returns>True if value approx. equals other</returns>
		public static bool KindaEquals(this in Vector4 v, in Vector4 other)
		{
			return
			Mathf.Approximately(v.x, other.x)
			&& Mathf.Approximately(v.y, other.y)
			&& Mathf.Approximately(v.z, other.z)
			&& Mathf.Approximately(v.w, other.w);
		}
	}
}

#endif