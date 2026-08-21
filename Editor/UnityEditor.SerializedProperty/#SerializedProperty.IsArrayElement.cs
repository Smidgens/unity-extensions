// smidgens @ github

#if UNITY_EDITOR

namespace Smidgenomics.Unity.Extensions.Editor
{
	using UnityEditor;

	public static partial class SerializedProperty_
	{
		/// <summary>
		/// [Editor] Returns true if given property is part of array
		/// </summary>
		public static bool IsArrayElement(this SerializedProperty p)
		{
			return p.propertyPath[^1] == ']';
		}
	}
}

#endif