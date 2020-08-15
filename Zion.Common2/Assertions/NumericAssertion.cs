using System;

namespace Zion.Common2.Assertions
{
    public partial class ZionAssertion
    {
        /// <summary>
        /// Return True if value between or equal min and max
        /// </summary>
        /// <param name="value"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static void IsBetweenOrEqual(long value, long min, long max, string message)
        {
            if (Checks.ZionCheck.IsBetweenOrEqual(value, min, max) == false)
                throw new Exception(message);
        }

        public static void IsBiggerThen(decimal value, decimal min, string message)
        {
            if (Checks.ZionCheck.IsBiggerThen(value, min) == false)
                throw new Exception(message);
        }

    }
}
