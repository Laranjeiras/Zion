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
    }
}
