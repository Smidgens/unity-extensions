// smidgens @ github

#if UNITY_EDITOR && !EXT_0_UNITYEDITOR_SERIALIZEDPROPERTY

namespace Smidgenomics.Unity.Extensions.Editor
{
	using UnityEditor;

	public static partial class SerializedProperty_
	{
		/// <summary>
		/// Determines if serialized property
		/// </summary>
		/// <param name="p">Serialized Property</param>
		/// <returns>True if SP is of type UnityEvent</returns>
		public static bool IsUnityEvent(this SerializedProperty p)
		{
			return
			p != null
			&& !p.isArray
			// not exactly sophisticated but sufficient enough
			&& p.FindPropertyRelative("m_PersistentCalls") != null;
		}
	}
}

#endif