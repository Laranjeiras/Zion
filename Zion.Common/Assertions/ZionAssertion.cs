using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Zion.Common.ValueObjects;

namespace Zion.Common.Assertions
{
    public partial class ZionAssertion
    {
        public static bool EmailIsValid(string email)
        {
            const string pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
