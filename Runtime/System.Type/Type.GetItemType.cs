// smidgens @ github

#if !EXT_0_SYSTEM_TYPE

namespace Smidgenomics.Unity.Extensions
{
	using System;

	public static partial class Type_
	{
		/// <summary>
		/// Returns element type for possible array
		/// </summary>
		/// <param name="t">Type</param>
		/// <returns>Innermost element type if array is supplied</returns>
		public static Type GetItemType(this Type t)
		{
			var elementType = t;

			// traverse the hierarchy until a non-array is found
			while (elementType.IsArray)
			{
				elementType = elementType.GetElementType();
			}
			return elementType;
		}
	}
}

#endif