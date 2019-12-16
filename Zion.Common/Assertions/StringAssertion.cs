using System;

namespace Zion.Common.Assertions
{
    [Obsolete("Changed to ZionAssertion")]
    public class StringAssertion
    {
        [Obsolete("Changed to ZionAssertion")]
        public static void IsNullOrEmptyOrWhiteSpace(string value, string message = "NullOrEmptyOrWhiteSpace")
        {
            ZionAssertion.StringIsNullOrEmptyOrWhiteSpace(value, message);
        }
    }

    public partial class ZionAssertion
    {
        public static void StringIsNullOrEmptyOrWhiteSpace(string value, string message = "NullOrEmptyOrWhiteSpace")
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                throw new Exception(message);
        }

        public static void StringHasLen(string value, int len, string message = "Invalid Len")
        {
            if (value == null) return;
            if (string.IsNullOrEmpty(value) || value.Length != len)
                throw new Exception(message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="minLength">Se informar valor 0, aceitará valores nullos</param>
        /// <param name="maxLength"></param>
        /// <param name="message"></param>
        public static void StringHasLen(string value, int minLength, int maxLength, string message = "Invalid Length")
        {
            if (value == null && minLength == 0) return;
            if (string.IsNullOrEmpty(value)) throw new Exception(message);

            if (value.Length < minLength || value.Length > maxLength)
                throw new Exception(message);
        }

        public static void StringHasMinLen(string value, int len, string message="Invalid HasMinLen") 
        {
            if (string.IsNullOrEmpty(value) || value.Length < len)
                throw new Exception(message);
        }

        public static void StringHasMaxLen(string value, int len, string message="Invalid HasMaxLen") 
        {
            if (string.IsNullOrEmpty(value) || value.Length > len)
                throw new Exception(message);
        }
    }
}
