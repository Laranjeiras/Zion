using System.Text.RegularExpressions;

namespace Zion.Common2.Checks
{
    public partial class ZionCheck
    {
        public static bool PhoneIsValid(string phoneNumber)
        {
            phoneNumber = Helpers.ZionHelper.OnlyNumbers(phoneNumber);
            if (phoneNumber == null || phoneNumber.Length == 0) return false;

            Regex rgxPhoneFormatDDD = new Regex(@"^\([0-9]{2}\)[0-9]{4,5}-[0-9]{4}$");
            Regex rgxPhoneNoFormat = new Regex(@"^([0-9]{10,11})$");
            var isMatch = rgxPhoneFormatDDD.IsMatch(phoneNumber) || rgxPhoneNoFormat.IsMatch(phoneNumber);

            return isMatch;
        }
    }
}
