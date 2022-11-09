// smidgens @ github

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;

	public static partial class Transform_
	{
		/// <summary>
		/// Apply matrix to transform (local)
		/// </summary>
		/// <param name="t">Transform</param>
		/// <param name="m">Matrix</param>
		public static void ApplyLocalMatrix(this Transform t, in Matrix4x4 m)
		{
			t.localRotation = m.rotation;
			t.localPosition = m.GetPosition();
			t.localScale = m.lossyScale;
		}
	}
}