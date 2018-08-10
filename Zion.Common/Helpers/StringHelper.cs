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
    }
}
