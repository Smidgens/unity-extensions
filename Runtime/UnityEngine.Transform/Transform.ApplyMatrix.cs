// smidgens @ github

#if !EXT_0_UNITYENGINE_TRANSFORM

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;

	public static partial class Transform_
	{
		/// <summary>
		/// Apply matrix to transform
		/// </summary>
		/// <param name="t">Transform</param>
		/// <param name="m">Matrix</param>
		public static void ApplyMatrix(this Transform t, in Matrix4x4 m)
		{
			t.rotation = m.rotation;
			t.position = m.GetPosition();
			t.localScale = m.lossyScale;
		}
	}
}

#endif