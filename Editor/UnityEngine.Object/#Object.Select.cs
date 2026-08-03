// smidgens @ github

#if UNITY_EDITOR && !EXT_0_UNITYENGINE_OBJECT

namespace Smidgenomics.Unity.Extensions.Editor
{
	using UnityEditor;
	using UnityEngine;

	public static partial class Editor_UnityObject_
	{
		/// <summary>
		/// Appends object/asset to selection
		/// </summary>
		/// <param name="o">Object to select</param>
		public static void Select(this Object o)
		{
			Object[] obs = Selection.objects;
			int i = System.Array.IndexOf(obs, o);
			if(i >= 0) { return; } // already included
			Object[] newSelection = new Object[obs.Length + 1];
			System.Array.Copy(obs, newSelection, obs.Length);
			newSelection[obs.Length] = o;
			Selection.objects = newSelection;
		}
	}
}

#endif