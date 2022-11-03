// smidgens @ github

namespace Smidgenomics.Unity.Extensions
{
	using System;

	public static partial class Type_
	{
		/// <summary>
		/// Checks if type is static class
		/// </summary>
		/// <param name="t">Type</param>
		/// <returns>True if type is a static class</returns>
		public static bool IsStaticClass(this Type t)
		{
			// sealed + abstract -> static
			return t.IsSealed && t.IsAbstract;
		}
	}
}