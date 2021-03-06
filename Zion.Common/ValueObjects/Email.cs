﻿using System;
using System.Collections.Generic;
using Zion.Common.Validations;

namespace Zion.Common.ValueObjects
{
    [Serializable]
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

        private bool IsValid(string value)
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
