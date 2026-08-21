// smidgens @ github

#if UNITY_EDITOR

namespace Smidgenomics.Unity.Extensions.Editor
{
	using UnityEditor;

	public static partial class SerializedObject_
	{
		/// <summary>
		/// [Editor] Retrieves SerializedProperty for object name
		/// </summary>
		/// <param name="so">SerializedObject</param>
		/// <returns>SerializedProperty</returns>
		public static SerializedProperty GetObjectNameProperty(this SerializedObject so)
		{
			return so.FindProperty("m_Name");
		}
	}
}

#endif