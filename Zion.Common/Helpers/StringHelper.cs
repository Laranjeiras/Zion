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

        public static string Between(string src, string start, string end)
        {
            if (src == null) return string.Empty;
            if (start == null) throw new ArgumentNullException("src");
            if (end == null) throw new ArgumentNullException("end");

            try
            {
                var i = src.IndexOf(start);
                var f = src.IndexOf(end);
                var l = f - i - start.Length;

                if (i < 0 || f < 0) return string.Empty;

                return src.Substring(i + start.Length, l);
            }
            catch (ArgumentOutOfRangeException)
            {
                return string.Empty;
            }
            catch
            {
                throw;
            }
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
