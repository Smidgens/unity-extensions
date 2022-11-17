// smidgens @ github

#if !EXT_0_UNITYENGINE_OBJECT

namespace Smidgenomics.Unity.Extensions.Editor
{
	using UnityEditor;
	using UnityEngine;

	internal static partial class UnityObject_
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