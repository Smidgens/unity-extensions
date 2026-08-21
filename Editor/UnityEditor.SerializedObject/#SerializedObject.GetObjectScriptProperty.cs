// smidgens @ github

#if UNITY_EDITOR

namespace Smidgenomics.Unity.Extensions.Editor
{
	using UnityEditor;

	public static partial class SerializedObject_
	{
		/// <summary>
		/// [Editor] Find SerializedProperty for MonoBehaviour/ScriptableObject script field
		/// </summary>
		/// <param name="so">SerializedObject</param>
		/// <returns>SerializedProperty</returns>
		public static SerializedProperty GetObjectScriptProperty(this SerializedObject so)
		{
			//
			return so.FindProperty("m_Script");
		}
	}
}

#endif