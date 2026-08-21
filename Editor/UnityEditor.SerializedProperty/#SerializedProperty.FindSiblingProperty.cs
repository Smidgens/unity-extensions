// smidgens @ github

#if UNITY_EDITOR

namespace Smidgenomics.Unity.Extensions.Editor
{
	using UnityEditor;

	public static partial class SerializedProperty_
	{
		/// <summary>
		/// [Editor] Tries to find sibling property by name
		/// </summary>
		/// <param name="prop">Property to look by</param>
		/// <param name="name">Property name</param>
		/// <returns></returns>
		public static SerializedProperty FindSiblingProperty(this SerializedProperty prop, string name)
		{
			// array item
			if (prop.propertyPath.EndsWith(']'))
			{
				return null;
			}
			var fieldName = prop.name;
			var basePath = prop.propertyPath.Substring(0, prop.propertyPath.Length - fieldName.Length);
			var togglePath = $"{basePath}{name}";
			return prop.serializedObject.FindProperty(togglePath);
		}
	}
}

#endif