// smidgens @ github

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;

	public static partial class Vector3_
	{
		/// <summary>
		/// Checks if all axes are approximately zero
		/// </summary>
		/// <param name="v">Vector3</param>
		/// <returns>True if magnitude is approximately zero</returns>
		public static bool IsKindaZero(this in Vector3 v)
		{
			return
			v.x.IsKindaZero()
			&& v.y.IsKindaZero()
			&& v.z.IsKindaZero();
		}
	}
}