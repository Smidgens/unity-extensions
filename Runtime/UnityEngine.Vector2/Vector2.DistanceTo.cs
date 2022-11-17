// smidgens @ github

#if !EXT_0_UNITYENGINE_VECTOR2

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;

	public static partial class Vector2_
	{
		/// <summary>
		/// Calculates distance between points
		/// </summary>
		/// <param name="a">Point A</param>
		/// <param name="b">Point B</param>
		/// <returns>Distance</returns>
		public static float DistanceTo(this in Vector2 a, in Vector2 b)
		{
			return Vector2.Distance(a, b);
		}
	}
}

#endif