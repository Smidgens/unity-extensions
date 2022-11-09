// smidgens @ github

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;

	public static partial class Vector2_
	{
		/// <summary>
		/// Checks if value approximately equals other
		/// </summary>
		/// <param name="v">Vector2</param>
		/// <param name="other">Other Vector2</param>
		/// <returns>True if value approx. equals other</returns>
		public static bool KindaEquals(this in Vector2 v, in Vector2 other)
		{
			return
			Mathf.Approximately(v.x, other.x)
			&& Mathf.Approximately(v.y, other.y);
		}
	}
}