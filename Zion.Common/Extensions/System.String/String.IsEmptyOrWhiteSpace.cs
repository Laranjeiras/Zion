
namespace Zion.Common.Extensions
{
    public partial class ZionExtensions
    {
        public static bool IsEmptyOrWhiteSpace(this string value)
        {
            return Helpers.StringHelper.IsNullOrEmptyOrWhiteSpace(value);
        }
    }
}
