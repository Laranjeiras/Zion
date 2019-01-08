using System;
using System.Collections.Generic;
using System.Text;

namespace Zion.Common.Assertions
{
    public partial class ZionAssertion
    {
        public static void PhoneNumberIsValid(string value, string message = "Phone Number is invalid")
        {
            if (!Validations.PhoneValidation.IsValid(value))
                throw new Exception(message);
        }
    }
}
