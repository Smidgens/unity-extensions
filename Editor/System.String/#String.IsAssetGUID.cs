// smidgens @ github

#pragma warning disable 0414

#if UNITY_EDITOR

namespace Smidgenomics.Unity.Extensions.Editor
{
	using System.Text.RegularExpressions;

	public static partial class _String_
	{
		public static bool IsAssetGUID(this string str)
		{
			return Regex.IsMatch(str, "^([a-f]|[0-9]){32}$");
		}
	}
}

#endif