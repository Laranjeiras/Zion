
using System;

namespace Zion.Common.Validations
{
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
    }
}
