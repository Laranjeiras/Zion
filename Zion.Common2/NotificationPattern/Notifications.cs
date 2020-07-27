using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Zion.Common2.NotificationPattern
{
    public partial class Notifications : Notifiable
    {
        public Notifications Requires()
        {
            return this;
        }

        public Notifications Join(params Notifiable[] items)
        {
            if (items != null)
            {
                foreach (var notifiable in items)
                {
                    if (notifiable.Valid)
                        AddNotifications(notifiable.Notifications);
                }
            }

            return this;
        }

        public Notifications IfNotNull(object parameterType, Expression<Func<Notifications, Notifications>> contractExpression)
        {
            if (parameterType != null)
            {
                contractExpression.Compile().Invoke(this);
            }

            return this;
        }
    }
}
