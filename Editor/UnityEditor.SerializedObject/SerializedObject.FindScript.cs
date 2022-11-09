// smidgens @ github

namespace Smidgenomics.Unity.Extensions.Editor
{
	using UnityEditor;

	internal static partial class SerializedObject_
	{
		/// <summary>
		/// Retrieves SerializedProperty for script field
		/// </summary>
		/// <param name="so">SerializedObject</param>
		/// <returns>SerializedProperty</returns>
		public static SerializedProperty FindScript(this SerializedObject so)
		{
			return so.FindProperty("m_Script");
		}
	}
}