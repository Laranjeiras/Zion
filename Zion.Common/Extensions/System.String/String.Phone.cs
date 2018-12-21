namespace Zion.Common.Extensions
{
    public partial class ZionExtensions
    {
        public static string PhoneFormat(this string value)
        {
            return Helpers.PhoneHelper.Format(value);
        }

        public static string PhoneOnlyNumbers(this string value)
        {
            return Helpers.PhoneHelper.OnlyNumbers(value);
        }

        public static string PhoneUnformatted(this string value)
        {
            return Helpers.PhoneHelper.OnlyNumbers(value);
        }
    }
}
