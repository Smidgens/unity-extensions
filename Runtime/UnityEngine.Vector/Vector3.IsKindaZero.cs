// smidgens @ github

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;

	public static partial class Vector3_
	{
		/// <summary>
		/// Checks if vector3 is approximately zero
		/// </summary>
		/// <param name="v">Vector3</param>
		/// <returns>True if magnitude is approximately zero</returns>
		public static bool IsKindaZero(this in Vector3 v) => v.magnitude.KindaZero();
	}
}