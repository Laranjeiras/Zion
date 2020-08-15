using System;
using System.Collections.Generic;
using Zion.Common2.Checks;
using Zion.Common2.Helpers;

namespace Zion.Common2.ValueObjects
{
    public class Phone
    {
        private readonly string _number;

        public Phone(string phoneNumber)
        {
            if (!ZionCheck.PhoneIsValid(phoneNumber)) 
                throw new Exception("Telefone inválido!");
            _number = ZionHelper.OnlyNumbers(phoneNumber);
        }

        public string Formatted => Format(_number);

        public string Unformatted => Unformat(_number);

        public override string ToString() => Formatted;

        public override bool Equals(object obj)
        {
            var phone = obj as Phone;
            return phone != null &&
                   _number == phone._number;
        }

        public override int GetHashCode()
        {
            return 769468832 + EqualityComparer<string>.Default.GetHashCode(_number);
        }

        /// <summary>
        /// Return (99)99999-9999 or (99)9999-9999
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string Format(string value)
        {
            if (!ZionCheck.PhoneIsValid(value))
                throw new Exception("Telefone inválido");

            var tmp = ZionHelper.OnlyNumbers(value);
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
        public static string Unformat(string value)
        {
            if (!ZionCheck.PhoneIsValid(value))
                throw new Exception("Telefone inválido");
            return ZionHelper.OnlyNumbers(value);
        }
    }
}
