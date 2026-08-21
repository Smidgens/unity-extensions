// smidgens @ github

#if UNITY_EDITOR

namespace Smidgenomics.Unity.Extensions.Editor
{
	using UnityEditor;
	using UnityEngine;

	public static partial class Editor_UnityObject_
	{
		/// <summary>
		/// [Editor] Sets given object as active in editor selection
		/// </summary>
		/// <param name="o">Object to set as active</param>
		public static void MakeActiveSelection(this Object o)
		{
			Selection.activeObject = o;
		}
	}
}

#endif