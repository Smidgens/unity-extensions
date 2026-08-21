// smidgens @ github

#if UNITY_EDITOR

namespace Smidgenomics.Unity.Extensions.Editor
{
	using UnityEditor;
	using UnityEngine;

	public static partial class Editor_UnityObject_
	{
		/// <summary>
		/// [Editor] Retrieves script asset for given asset
		/// </summary>
		/// <param name="ob">MonoBehaviour or ScriptableObject</param>
		/// <returns>Script asset, null if given object is invalid</returns>
		public static MonoScript GetMonoScript(this Object ob)
		{
			var assetType = ob.GetType();

			var isSO = typeof(ScriptableObject).IsAssignableFrom(assetType);
			var isMB = typeof(MonoBehaviour).IsAssignableFrom(assetType);

			if (!isSO && isMB)
			{
				return null;
			}

			// this seems slightly more tedious than it needs to be, whatever...
			return isSO
			? MonoScript.FromScriptableObject((ScriptableObject)ob)
			: MonoScript.FromMonoBehaviour((MonoBehaviour)ob);
		}
	}
}

#endif