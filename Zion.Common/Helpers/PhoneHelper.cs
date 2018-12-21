using System;

namespace Zion.Common.Helpers
{
    public class PhoneHelper
    {
        /// <summary>
        /// Return (99)99999-9999 or (99)9999-9999
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string Format(string value)
        {
            if (!Validations.PhoneValidation.IsValid(value)) throw new Exception("Telefone inválido");

            var tmp = StringHelper.OnlyNumbers(value);
            if (tmp.Length == 10)
                return long.Parse(value).ToString(@"(00)0000-0000");
            if (tmp.Length == 11)
                return long.Parse(value).ToString(@"(00)00000-0000");

            throw new Exception("Telefone inválido");
        }

        /// <summary>
        /// Return only numbers in Telefone
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string Unformatted(string value)
        {
            if (!Validations.PhoneValidation.IsValid(value)) throw new Exception("Telefone inválido");
            return StringHelper.OnlyNumbers(value);
        }

        /// <summary>
        /// Return only numbers in Telefone
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string OnlyNumbers(string value)
        {
            if (!Validations.PhoneValidation.IsValid(value)) throw new Exception("Telefone inválido");
            return StringHelper.OnlyNumbers(value);
        }
    }
}
