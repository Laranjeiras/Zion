namespace Zion.Common.Extensions
{
    public partial class ZionExtensions
    {
        public static bool HasLen(this string value, int len)
        {
            return Validations.ZionValidation.StringHasLen(value, len);
        }
    }
}
