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

        [Obsolete("Substituido por MaxLenght")]
        public static string AdjustString(string text, int size)
        {
            return MaxLength(text, size, false);
        }

        /// <summary>
        /// Return text with maxlength = size
        /// If size = 0, return string.Empty
        /// IF text = null, return null
        /// </summary>
        /// <param name="text"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static string MaxLength(string text, int size, bool allTrim = true)
        {
            if (text == null) return null;
            if (size <= 0) return string.Empty;

            if (allTrim)
                text = text.TrimEnd().Trim().TrimStart();
            if (text.Length > size)
                text = text.Substring(0, size);
            return text;
        }

        public static bool IsNullOrEmptyOrWhiteSpace(string value)
        {
            return (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value));
        }
    }
}
