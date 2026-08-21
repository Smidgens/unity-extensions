// smidgens @ github

namespace Smidgenomics.Unity.Extensions
{
	using System;
	using System.Reflection;

	public static partial class Type_
	{
		/// <summary>
		/// Looks for custom attribute on enum value
		/// </summary>
		/// <exception cref="ArgumentException">When given type is not enum</exception>
		public static T GetEnumValueAttribute<T>(Type enumType, int value) where T : Attribute
		{
			if (!enumType.IsEnum)
			{
				throw new ArgumentException("Supplied type is not enum");
			}
			var name = Enum.GetName(enumType, value);
			return enumType.GetField(name)?.GetCustomAttribute<T>();
		}
	}
}