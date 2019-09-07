using System;

namespace Zion.Common.Assertions
{
    public partial class ZionAssertion
    {
        public static void IsBiggerThen(decimal value, decimal min, string message = "Value is invalid") 
        {
            if (!Helpers.NumericHelper.IsBiggerThen(value,min))
                throw new Exception(message);
        }

        public static void IsBiggerThen(long value, decimal min, string message = "Value is invalid")
        {
            if (!Helpers.NumericHelper.IsBiggerThen(value, min))
                throw new Exception(message);
        }
    }
}
