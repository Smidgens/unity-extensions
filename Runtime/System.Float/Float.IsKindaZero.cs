// smidgens @ github

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;

	public static partial class Float_
	{
		/// <summary>
		/// Syntactic sugar, equivalent to Mathf.Approximately(v, 0f);
		/// </summary>
		public static bool IsKindaZero(this in float v) => Mathf.Approximately(0f, v);
	}
}