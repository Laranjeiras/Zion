using System;
using System.Text.RegularExpressions;

namespace Zion.Common.Assertions
{
    public partial class ZionAssertion
    {
        public static void EmailIsValid(string email, string message = "Email is invalid")
        {
            if(!Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
                throw new Exception(message);

            //const string pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            //if (!Regex.IsMatch(email, pattern))
            //    throw new Exception(message);
        }
    }
}
