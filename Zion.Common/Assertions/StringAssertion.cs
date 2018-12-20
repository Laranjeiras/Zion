using System;

namespace Zion.Common.Assertions
{
    public class StringAssertion
    {
        public static void IsNullOrEmptyOrWhiteSpace(string value, string message = "NullOrEmptyOrWhiteSpace")
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new Exception(message);
            }
        }
    }
}
