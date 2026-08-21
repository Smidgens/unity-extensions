// smidgens @ github

#if UNITY_EDITOR

namespace Smidgenomics.Unity.Extensions.Editor
{
	using UnityEditor;
	using UnityEngine;
	using System.Linq;

	public static partial class Editor_UnityObject_
	{
		/// <summary>
		/// [Editor] Removes object from editor selection
		/// </summary>
		/// <param name="o">Object to remove from selection</param>
		public static void Deselect(this Object o)
		{
			Selection.objects = Selection.objects.Where(ob => ob != o).ToArray();
		}
	}
}

#endif