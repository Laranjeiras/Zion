using System;
using System.Collections.Generic;
using Zion.Common2.Validations;

namespace Zion.Common2.ValueObjects
{
    public class Email
    {
        public string Value { get; set; }

        protected Email()
        {
            Value = null;
        }

        public Email(string email)
        {
            if (!IsValid(email))
                throw new Exception("Email inválido!");
            Value = email;
        }

        private static bool IsValid(string value)
        {
            return ZionValidation.EmailValidation(value);
        }

        public bool IsValid()
        {
            return IsValid(Value);
        }

        public override string ToString()
        {
            return Value?.ToLower();
        }

        public override bool Equals(object obj)
        {
            return obj is Email email &&
                   Value == email.Value;
        }

        public override int GetHashCode()
        {
            return -1937169414 + EqualityComparer<string>.Default.GetHashCode(Value);
        }
    }
}
