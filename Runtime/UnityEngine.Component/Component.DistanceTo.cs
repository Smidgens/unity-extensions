// smidgens @ github

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;

	public static partial class Component_
	{
		/// <summary>
		/// Calculates distance between components
		/// </summary>
		/// <param name="a">Component A</param>
		/// <param name="b">Component B</param>
		/// <returns>Distance</returns>
		public static float DistanceTo(this Component a, Component b)
		{
			return Vector3.Distance(a.transform.position, b.transform.position);
		}
	}
}