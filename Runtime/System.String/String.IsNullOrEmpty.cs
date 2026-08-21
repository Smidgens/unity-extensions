// smidgens @ github

namespace Smidgenomics.Unity.Extensions
{
	public static partial class String_
	{
		/// <summary>
		/// Shorthand for string.IsNullOrEmpty(s)
		/// </summary>
		public static bool IsNullOrEmpty(this string s)
		{
			return string.IsNullOrEmpty(s);
		}
	}
}