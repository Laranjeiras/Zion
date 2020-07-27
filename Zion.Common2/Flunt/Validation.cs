using System;
using System.Collections.Generic;
using System.Text;

namespace Zion.Common2.Flunt
{
    [Obsolete("Replaced for NotificationPattern")]
    public class Validation
    {
        public Validation(string property, string message)
        {
            Property = property;
            Message = message;
        }

        public string Property { get; private set; }
        public string Message { get; private set; }

        public override bool Equals(object obj)
        {
            var validation = obj as Validation;
            return validation != null &&
                   Property == validation.Property &&
                   Message == validation.Message;
        }

        public override int GetHashCode()
        {
            var hashCode = -1618876500;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Property);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Message);
            return hashCode;
        }
    }
}
