// smidgens @ github

#pragma warning disable 0414

namespace Smidgenomics.Unity.Extensions
{
	using System.Text.RegularExpressions;

	public static partial class String_
	{
		/// <summary>
		/// Tests if given string contains only hex characters
		/// </summary>
		public static bool IsHexString(this string str)
		{
			return !string.IsNullOrEmpty(str) && Regex.IsMatch(str, "^([a-f]|[0-9])+$");
		}
	}
}

