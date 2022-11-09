// smidgens @ github

namespace Smidgenomics.Unity.Extensions.Editor
{
	using UnityEditor;
	using UnityEngine;

	internal static partial class UnityObject_
	{
		/// <summary>
		/// Sets given object as active in editor selection
		/// </summary>
		/// <param name="o">Object to set as active</param>
		public static void MakeActiveSelection(this Object o)
		{
			Selection.activeObject = o;
		}
	}
}