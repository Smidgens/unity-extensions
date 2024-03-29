// smidgens @ github

#if UNITY_EDITOR && !EXT_0_UNITYEDITOR_SERIALIZEDOBJECT

namespace Smidgenomics.Unity.Extensions.Editor
{
	using UnityEditor;

	public static partial class SerializedObject_
	{
		/// <summary>
		/// Retrieves SerializedProperty for object name
		/// </summary>
		/// <param name="so">SerializedObject</param>
		/// <returns>SerializedProperty</returns>
		public static SerializedProperty FindName(this SerializedObject so)
		{
			return so.FindProperty("m_Name");
		}
	}
}

#endif