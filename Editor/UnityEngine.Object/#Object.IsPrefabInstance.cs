// smidgens @ github

#if UNITY_EDITOR && !EXT_0_UNITYENGINE_OBJECT

namespace Smidgenomics.Unity.Extensions.Editor
{
	using UnityEditor;
	using UnityEngine;

	public static partial class Editor_UnityObject_
	{
		/// <summary>
		/// [Editor] Returns true if given object is part of prefab
		/// </summary>
		public static bool IsPrefabInstance(this UnityEngine.Object o)
		{
			return PrefabUtility.GetPrefabInstanceStatus(o) != PrefabInstanceStatus.NotAPrefab;
		}
	}
}

#endif