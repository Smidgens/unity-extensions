// smidgens @ github

#if !EXT_0_SYSTEM_STRING

namespace Smidgenomics.Unity.Extensions
{
	using System.Text;

	public static partial class String_
	{
		/// <summary>
		/// Adds spaces between words in pascal or camel cased string
		/// </summary>
		/// <param name="s">Camel/pascal cased string</param>
		/// <returns>Sentence-converted string</returns>
		public static string ToSentence(this string s)
		{
			var sb = new StringBuilder();
			for(var i = 0; i < s.Length; i++)
			{
				var c = s[i];
				if(i > 0)
				{
					if (char.IsLower(s[i - 1]) && char.IsUpper(s[i]))
					{
						sb.Append(" ");
					}
				}
				sb.Append(c);
			}
			return sb.ToString();
		}
	}
}

#endif
