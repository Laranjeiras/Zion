namespace Zion.Common.Extensions
{
    public static partial class ZionExtensions
    {
        /// <summary>
        /// Return True if value between or equal min and max
        /// </summary>
        /// <param name="value"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static bool IsBetweenOrEqual(this long value, long min, long max)
        {
            return Helpers.NumericHelper.IsBetweenOrEqual(value, min, max);
        }

        /// <summary>
        /// Return True if value between or equal min and max
        /// </summary>
        /// /// <param name="value"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static bool IsBetweenOrEqual(this int value, int min, int max)
        {
            return Helpers.NumericHelper.IsBetweenOrEqual(value, min, max);
        }
    }
}
