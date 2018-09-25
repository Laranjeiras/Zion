﻿namespace Zion.Common.Helpers
{
    public class NumericHelper
    {
        /// <summary>
        /// Return True if value between or equal min and max
        /// </summary>
        /// <param name="value"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static bool IsBetweenOrEqual(long value, long min, long max)
        {
            if (value >= min && value <= max)
                return true;
            return false;
        }
    }
}