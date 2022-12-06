// smidgens @ github

#if UNITY_EDITOR && !EXT_0_UNITYEDITOR_SERIALIZEDOBJECT

namespace Smidgenomics.Unity.Extensions.Editor
{
	using UnityEditor;

	public static partial class SerializedObject_
	{
		/// <summary>
		/// Find SerializedProperty for MonoBehaviour/ScriptableObject script field
		/// </summary>
		/// <param name="so">SerializedObject</param>
		/// <returns>SerializedProperty</returns>
		public static SerializedProperty FindScript(this SerializedObject so)
		{
			//
			return so.FindProperty("m_Script");
		}
	}
}

#endif