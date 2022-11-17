// smidgens @ github

#if !EXT_0_UNITYENGINE_OBJECT

namespace Smidgenomics.Unity.Extensions.Editor
{
	using UnityEditor;
	using UnityEngine;

	internal static partial class UnityObject_
	{
		/// <summary>
		/// Creates new nested scriptable object asset
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="parent">Main asset</param>
		/// <param name="name">Instance name</param>
		/// <param name="hideFlags">Project view visibility</param>
		/// <returns>Newly created instance</returns>
		public static T CreateNestedAsset<T>
		(
			this Object parent,
			string name = null,
			in HideFlags hideFlags = HideFlags.None
		) where T : ScriptableObject
		{
			var ob = ScriptableObject.CreateInstance<T>();

			if (string.IsNullOrEmpty(name))
			{
				name = $"New {typeof(T).Name}";
			}
			ob.name = name;
			ob.hideFlags = hideFlags;
			Undo.RegisterCreatedObjectUndo(ob, $"Instantiate {typeof(T).Name}");
			AssetDatabase.AddObjectToAsset(ob, parent);
			return ob;
		}
	}
}

#endif