// smidgens @ github

#if !EXT_0_UNITYENGINE_COMPONENT

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;

	public static partial class Component_
	{
		/// <summary>
		/// Checks if given component is nested under other in hierarchy
		/// </summary>
		/// <param name="c1">Child</param>
		/// <param name="c2">Possible parent</param>
		/// <returns>True if component is child</returns>
		public static bool IsChildOf(this Component c1, Component c2)
		{
			Transform current = c1.transform.parent;
			// traverse parents
			while (current != null)
			{
				if (current == c2.transform) { return true; }
				current = current.parent;
			}
			return false;
		}
	}
}

#endif