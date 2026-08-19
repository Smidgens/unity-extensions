// smidgens @ github

#pragma warning disable 0414

#if UNITY_EDITOR

namespace Smidgenomics.Unity.Extensions.Editor
{
	using System.Text.RegularExpressions;

	public static partial class _String_
	{
		/// <summary>
		/// Tests if given string conforms to a valid asset GUID
		/// </summary>
		public static bool IsAssetGUID(this string str)
		{
			return Regex.IsMatch(str, "^([a-f]|[0-9]){32}$");
		}
	}
}

#endif