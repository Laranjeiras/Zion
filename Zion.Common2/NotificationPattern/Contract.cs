﻿using System;
using System.Linq.Expressions;

namespace Zion.Common2.NotificationPattern
{
    public partial class Contract : Notifiable
    {
        public Contract Requires()
        {
            return this;
        }

        public Contract Join(params Notifiable[] items)
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

        public Contract IfNotNull(object parameterType, Expression<Func<Contract, Contract>> contractExpression)
        {
            if (parameterType != null)
            {
                contractExpression.Compile().Invoke(this);
            }

            return this;
        }
    }
}