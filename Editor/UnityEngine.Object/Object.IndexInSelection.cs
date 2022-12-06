// smidgens @ github

#if UNITY_EDITOR && !EXT_0_UNITYENGINE_OBJECT

namespace Smidgenomics.Unity.Extensions.Editor
{
	using UnityEditor;
	using UnityEngine;

	public static partial class Editor_UnityObject_
	{
		/// <summary>
		/// Finds index of asset in currently selected assets
		/// </summary>
		/// <param name="o">Object</param>
		/// <returns>Index in Selection.objects, -1 if not selected</returns>
		public static int IndexInSelection(this Object o)
		{
			var obs = Selection.objects;
			for (var i = 0; i < obs.Length; i++)
			{
				if(obs[i] == o) { return i; }
			}
			return -1;
		}
	}
}

#endif