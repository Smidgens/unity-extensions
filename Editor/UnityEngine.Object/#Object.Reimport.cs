// smidgens @ github

#if UNITY_EDITOR && !EXT_0_UNITYENGINE_OBJECT

namespace Smidgenomics.Unity.Extensions.Editor
{
	using UnityEditor;
	using UnityEngine;

	public static partial class Editor_UnityObject_
	{
		/// <summary>
		/// Reimport asset
		/// </summary>
		/// <param name="o">Unity Object</param>
		public static void Reimport(this Object o)
		{
			string path = AssetDatabase.GetAssetPath(o);
			AssetDatabase.ImportAsset(path);
		}

	}
}

#endif