
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
            catch(Exception)
            {
                return true;
            }
        }
    }
}
