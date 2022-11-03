// smidgens @ github

namespace Smidgenomics.Unity.Extensions
{
	using System.Text;

	public static partial class String_
	{
		/// <summary>
		/// Adds spaces between words in pascal or camel cased string
		/// </summary>
		/// <param name="str">Camel/pascal cased string</param>
		/// <returns>Sentence-converted string</returns>
		public static string ToSentenceCase(this string str)
		{
			var sb = new StringBuilder();
			for(var i = 0; i < str.Length; i++)
			{
				var c = str[i];
				if(i > 0)
				{
					if (char.IsLower(str[i - 1]) && char.IsUpper(str[i]))
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