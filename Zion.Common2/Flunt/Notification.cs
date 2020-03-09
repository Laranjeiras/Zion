using System;
using System.Collections.Generic;

namespace Zion.Common2.Flunt
{
    [Obsolete]
    public class Notification
    {
        public Notification(string property, string message)
        {
            Property = property;
            Message = message;
        }

        public string Property { get; private set; }
        public string Message { get; private set; }

        public override bool Equals(object obj)
        {
            var notification = obj as Validation;
            return notification != null &&
                   Property == notification.Property &&
                   Message == notification.Message;
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
