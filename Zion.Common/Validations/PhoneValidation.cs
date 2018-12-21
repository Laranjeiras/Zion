using System.Text.RegularExpressions;

namespace Zion.Common.Validations
{
    public class PhoneValidation
    {
        public static bool IsValid(string phoneNumber)
        {
            phoneNumber = Helpers.StringHelper.OnlyNumbers(phoneNumber);
            if (phoneNumber == null || phoneNumber.Length == 0) return false;

            Regex rgxPhoneFormatDDD = new Regex(@"^\([0-9]{2}\)[0-9]{4,5}-[0-9]{4}$");
            Regex rgxPhoneNoFormat = new Regex(@"^([0-9]{10,11})$");
            return rgxPhoneNoFormat.IsMatch(phoneNumber);
        }
    }
}
