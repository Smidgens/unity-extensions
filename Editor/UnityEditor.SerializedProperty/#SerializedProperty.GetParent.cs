// smidgens @ github

#if UNITY_EDITOR && !EXT_0_UNITYEDITOR_SERIALIZEDPROPERTY

namespace Smidgenomics.Unity.Extensions.Editor
{
	using System;
	using UnityEditor;

	public static partial class SerializedProperty_
	{
		/// <summary>
		/// Retrieves parent property
		///
		/// - If the given property is an array element, the outer array prop is returned
		/// - If property exists on the root level, null is returned
		/// </summary>
		public static SerializedProperty GetParent(this SerializedProperty p)
		{
			if (p.IsArrayElement())
			{
				// array items have the path <parent_path>.Array.data[<index>]
				var pPath = p.propertyPath.Substring(0, p.propertyPath.LastIndexOf(".Array", StringComparison.Ordinal));
				return p.serializedObject.FindProperty(pPath);
			}
			var lastSeparator = p.propertyPath.LastIndexOf('.');
			if (lastSeparator < 0)
			{
				// the property exists on the object root level
				return null;
			}
			return p.serializedObject.FindProperty(p.propertyPath.Substring(lastSeparator));
		}
	}
}

#endif