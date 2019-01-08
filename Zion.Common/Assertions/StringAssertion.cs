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
    }
}
