using System;
using System.Collections.Generic;

namespace Zion.Common.ValueObjects
{
    public class Phone
    {
        private string _number;

        public Phone(string phoneNumber)
        {
            if (!Validations.PhoneValidation.IsValid(phoneNumber)) throw new Exception("Telefone inválido!");
            _number = Helpers.PhoneHelper.OnlyNumbers(phoneNumber);
        }

        public string Formatted => Helpers.PhoneHelper.Format(_number);

        public string Unformatted => Helpers.PhoneHelper.Unformatted(_number);

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

        public static bool IsValid(string phoneNumber)
        {
            return Validations.PhoneValidation.IsValid(phoneNumber);
        }
    }
}
