
using System;

namespace Zion.Common.Validations
{
    [Obsolete("Changed to ZionValidation")]
    public class StringValidation
    {
        public static bool IsNullOrEmptyOrWhiteSpace(string value)
        {
            try
            {
                Assertions.StringAssertion.IsNullOrEmptyOrWhiteSpace(value);
                return false;
            }
            catch (Exception)
            {
                return true;
            }
        }
    }

    public partial class ZionValidation
    {
        public static bool IsNullOrEmptyOrWhiteSpace(string value)
        {
            try
            {
                Assertions.ZionAssertion.StringIsNullOrEmptyOrWhiteSpace(value);
                return false;
            }
            catch (Exception)
            {
                return true;
            }
        }

        public static bool StringHasLen(string value, int len)
        {
            try
            {
                Assertions.ZionAssertion.StringHasLen(value, len);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="minLength">Se informar valor 0, aceitará valores nullos</param>
        /// <param name="maxLength"></param>
        public static bool StringHasLen(string value, int minLength, int maxLength)
        {
            try
            {                
                Assertions.ZionAssertion.StringHasLen(value, minLength, maxLength);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
