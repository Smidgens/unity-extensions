// smidgens @ github

#if !EXT_0_UNITYENGINE_OBJECT

namespace Smidgenomics.Unity.Extensions.Editor
{
	using UnityEditor;
	using UnityEngine;
	using System.Linq;

	internal static partial class UnityObject_
	{
		/// <summary>
		/// Removes object from editor selection
		/// </summary>
		/// <param name="o">Object to remove from selection</param>
		public static void Deselect(this Object o)
		{
			Selection.objects = Selection.objects.Where(ob => ob != o).ToArray();
		}
	}
}

#endif