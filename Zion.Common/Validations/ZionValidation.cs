using System;

namespace Zion.Common.Validations
{
    public partial class ZionValidation
    {
        public static bool EmailValidation(string email)
        {
            try
            {
                Assertions.ZionAssertion.EmailIsValid(email);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
