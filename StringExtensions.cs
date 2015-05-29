using System;

namespace StringExtensions
{
	public static class StringExtensions
	{
		public static string maxLengthTrim(this String str, int maxLength)
		{
			if (str == null)
				return str;
			if (str.Length > maxLength)
				return str.Substring(0, maxLength - 1);
			return str;
		}

		public static bool isNullOrEmpty(this String str)
		{
			return String.IsNullOrEmpty(str);
		}

		public static bool isNotNullOrEmpty(this String str)
		{
			return !String.IsNullOrEmpty(str);
		}

		public static bool isNullOrWhiteSpace(this String str)
		{
			return String.IsNullOrWhiteSpace(str);
		}

		public static bool isNotNullOrWhiteSpace(this String str)
		{
			return !String.IsNullOrWhiteSpace(str);
		}
	}
}