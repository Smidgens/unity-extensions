// smidgens @ github

#if UNITY_EDITOR

namespace Smidgenomics.Unity.Extensions.Editor
{
	using UnityEditor;
	using UnityEngine;

	public static partial class Editor_UnityObject_
	{
		/// <summary>
		/// [Editor] Checks if given object exists in Asset Database
		/// </summary>
		/// <param name="o">Object</param>
		/// <returns>True if object is a project asset</returns>
		public static bool IsAsset(this Object o)
		{
			return AssetDatabase.Contains(o);
		}
	}
}

#endif