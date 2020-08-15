using System;
using System.Text.RegularExpressions;

namespace Zion.Common2.Checks
{
    public partial class ZionCheck
    {
        public static bool EmailValidation(string email)
        {
            if (email == null)
                return false;
            if (Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
                return true;
            return false;
        }

        public static bool PhoneIsValid(string phoneNumber)
        {
            phoneNumber = Helpers.ZionHelper.OnlyNumbers(phoneNumber);
            if (phoneNumber == null || phoneNumber.Length == 0) return false;

            Regex rgxPhoneFormatDDD = new Regex(@"^\([0-9]{2}\)[0-9]{4,5}-[0-9]{4}$");
            Regex rgxPhoneNoFormat = new Regex(@"^([0-9]{10,11})$");
            var isMatch = rgxPhoneFormatDDD.IsMatch(phoneNumber) || rgxPhoneNoFormat.IsMatch(phoneNumber);

            return isMatch;
        }

        public static bool IsNullOrEmpty(Guid? guid)
        {
            if (guid == null || guid == Guid.Empty)
                return true;
            return false;
        }
    }
}
