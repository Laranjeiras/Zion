
namespace Zion.Common.Extensions
{
    public partial class ZionExtensions
    {
        public static string OnlyNumbers(this string value)
        {
            return Helpers.StringHelper.OnlyNumbers(value);
        }
    }
}
