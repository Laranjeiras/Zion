using System;

namespace Zion.Common.Extensions
{
    public static partial class ZionExtensions
    {

        public static DateTime EndOfDay(this DateTime @this)
        {
            return new DateTime(@this.Year, @this.Month, @this.Day).AddDays(1).Subtract(new TimeSpan(0, 0, 0, 0, 1));
        }

        public static DateTime EndOfWeek(this DateTime @this, DayOfWeek endOfWeek = DayOfWeek.Saturday)
        {
            int diff = (7 + (endOfWeek - @this.DayOfWeek)) % 7;
            return @this.AddDays(diff).Date;
        }

        public static DateTime EndOfMonth(this DateTime @this)
        {
            return new DateTime(@this.Year, @this.Month, 1).AddMonths(1).Subtract(new TimeSpan(0, 0, 0, 0, 1));
        }

        public static DateTime EndOfYear(this DateTime @this)
        {
            return new DateTime(@this.Year, 1, 1).AddYears(1).Subtract(new TimeSpan(0, 0, 0, 0, 1));
        }

        public static bool IsWeekDay(this DateTime @this)
        {
            return !(@this.DayOfWeek == DayOfWeek.Saturday || @this.DayOfWeek == DayOfWeek.Sunday);
        }

        public static bool IsWeekendDay(this DateTime @this)
        {
            return (@this.DayOfWeek == DayOfWeek.Saturday || @this.DayOfWeek == DayOfWeek.Sunday);
        }

        public static DateTime StartOfDay(this DateTime @this)
        {
            return new DateTime(@this.Year, @this.Month, @this.Day);
        }

        public static DateTime StartOfWeek(this DateTime @this, DayOfWeek startOfWeek = DayOfWeek.Sunday)
        {
            int diff = (7 + (@this.DayOfWeek - startOfWeek)) % 7;
            return @this.AddDays(-1 * diff).Date;
        }



        public static DateTime StartOfMonth(this DateTime @this)
        {
            return new DateTime(@this.Year, @this.Month, 1);
        }

        public static DateTime StartOfYear(this DateTime @this)
        {
            return new DateTime(@this.Year, 1, 1);
        }
    }
}
