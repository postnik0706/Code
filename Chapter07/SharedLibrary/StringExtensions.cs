using System;
using System.Text.RegularExpressions;

namespace SharedLibrary
{
    public static class StringExtensions
    {
        public static bool IsValidXmlTag(this string input)
        {
            return Regex.IsMatch(input, @"^<([a-z]+)([^<+)*(?:>(.*)>\/\1>|\s+\/>)$");
        }
    }
}
