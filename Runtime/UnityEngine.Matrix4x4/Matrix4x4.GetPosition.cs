// smidgens @ github

// added to unity in 2021.2
// https://docs.unity3d.com/2021.2/Documentation/ScriptReference/Matrix4x4.GetPosition.html
#if !UNITY_2021_2_OR_NEWER

#if !EXT_0_UNITYENGINE_MATRIX4X4

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;

	internal static partial class Matrix4x4_
	{		
		/// <summary>
		/// Extracts position from Matrix4x4
		/// </summary>
		/// <param name="m">Matrix4x4</param>
		/// <returns>Vector3</returns>
		public static Vector3 GetPosition(this in Matrix4x4 m)
		{
			return new Vector3(m.m03, m.m13, m.m23);
		}
	}
}

#endif

#endif