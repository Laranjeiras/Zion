using System;
using System.Text.RegularExpressions;

namespace Zion.Common2.Assertions
{
    public partial class ZionAssertion
    {
        public static void PhoneIsValid(string phoneNumber, string message)
        {
            if (!Checks.ZionCheck.PhoneIsValid(phoneNumber))
                throw new Exception(message);
        }

        public static void EmailIsValid(string email, string message = "Email is invalid")
        {
            if (!Checks.ZionCheck.EmailValidation(email))
                throw new Exception(message);
        }
        public static void ObjectIsNull(object value, string message = "Object is Null")
        {
            if (value == null)
                throw new Exception(message);
        }
    }
}
