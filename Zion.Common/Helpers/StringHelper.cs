using System;
using System.Linq;

namespace Zion.Common.Helpers
{
    public class StringHelper
    {
        public static string OnlyNumbers(string value)
        {
            return string.IsNullOrEmpty(value) ? null : new String(value.Where(Char.IsDigit).ToArray());
        }

        public static string AdjustString(string text, int size)
        {
            if (text == null) return null;
            if (size <= 0) return text;
            if (text.Length > size)
                text = text.Substring(0, size - 1);
            return text;
        }

        public static bool IsNullOrEmptyOrWhiteSpace(string value)
        {
            return (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value));
        }
    }
}
