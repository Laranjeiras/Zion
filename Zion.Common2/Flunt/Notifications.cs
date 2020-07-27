using System;
using System.Collections.Generic;

namespace Zion.Common2.Flunt
{
    [Obsolete("Replaced for NotificationPattern")]
    public partial class Notifications : Notifiable
    {
        public Notifications(IList<Notification> notifications)
        {
            base.AddNotifications(notifications);
        }

        public Notifications(Notification notification)
        {

        }

        public Notifications()
        {

        }
    }
}
