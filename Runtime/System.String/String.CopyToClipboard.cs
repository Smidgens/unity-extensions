// smidgens @ github

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;

	public static partial class String_
	{
		/// <summary>
		/// Shorthand for GUIUtility.systemCopyBuffer = s
		/// </summary>
		public static void CopyToClipboard(this string s)
		{
			GUIUtility.systemCopyBuffer = s ?? string.Empty;
		}
	}
}