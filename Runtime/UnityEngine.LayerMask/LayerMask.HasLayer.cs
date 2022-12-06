// smidgens @ github

#if !EXT_0_UNITYENGINE_LAYERMASK

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;

	public static partial class LayerMask_
	{
		/// <summary>
		/// Check if mask contains layer
		/// </summary>
		/// <param name="mask">Mask</param>
		/// <param name="layer">Layer</param>
		/// <returns>True if mask is in layer</returns>
		public static bool HasLayer(this in LayerMask mask, in int layer)
		{
			// linus torvalds has weird hair
			return mask == (mask | (1 << layer));
		}
	}
}

#endif