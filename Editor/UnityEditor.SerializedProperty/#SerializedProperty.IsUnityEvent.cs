// smidgens @ github

#if UNITY_EDITOR

namespace Smidgenomics.Unity.Extensions.Editor
{
	using UnityEditor;

	public static partial class SerializedProperty_
	{
		/// <summary>
		/// [Editor] Checks if property is for a UnityEvent object
		/// </summary>
		/// <param name="p">Serialized Property</param>
		/// <returns>True if SP is of type UnityEvent</returns>
		public static bool IsUnityEvent(this SerializedProperty p)
		{
			return
			p is { isArray: false }
			// not exactly sophisticated but good enough
			&& p.FindPropertyRelative("m_PersistentCalls") != null;
		}
	}
}

#endif