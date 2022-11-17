// smidgens @ github

#if !EXT_0_UNITYENGINE_VECTOR3

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;

	public static partial class Vector3_
	{
		/// <summary>
		/// Calculates distance between points
		/// </summary>
		/// <param name="a">Point A</param>
		/// <param name="b">Point B</param>
		/// <returns>Distance</returns>
		public static float DistanceTo(this in Vector3 a, in Vector3 b)
		{
			return Vector3.Distance(a, b);
		}
	}
}

#endif