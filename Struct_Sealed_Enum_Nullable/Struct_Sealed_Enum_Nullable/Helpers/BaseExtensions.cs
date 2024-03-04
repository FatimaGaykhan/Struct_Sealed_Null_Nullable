using System;
using System.Text.RegularExpressions;

namespace Struct_Sealed_Enum_Nullable.Helpers
{
	public static class BaseExtensions
	{
		public static bool CheckStr(this string str,char symbol)
		{
			return str.Contains(symbol);
		}

		public static bool CheckPasswordLength(this string password)
		{
			return password.Length > 8;
		}

		public static bool CheckTextWithRegex(this string str,string pattern)
		{
			return Regex.IsMatch(str,pattern);
		}

		public static int MultiplearrayItems(this int[] nums)
		{
			int multiple = 1;
			foreach (var item in nums)
			{
				multiple *= item;
			}
			return multiple; 
		}






	}
}

