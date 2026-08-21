// smidgens @ github

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;
	using System;

	public static partial class GameObject_
	{
		/// <summary>
		/// Adds components of given types
		/// </summary>
		/// <param name="ob">GameObject</param>
		/// <param name="types">Component Types</param>
		/// <returns>Newly added components</returns>
		public static Component[] AddComponents(this GameObject ob, params Type[] types)
		{
			Component[] components = new Component[types.Length];
			for (var i = 0; i < types.Length; i++) { components[i] = ob.AddComponent(types[i]); }
			return components;
		}
	}
}