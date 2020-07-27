namespace Zion.Common2.NotificationPattern
{
    public partial class Notifications
    {
        public Notifications IsNotNullOrEmpty(string val, string property, string message)
        {
            if (Checks.ZionCheck.StringIsNullOrEmptyOrWhiteSpace(val))
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="minLength">If minLength = 0 return true if null</param>
        /// <param name="maxLength"></param>
        /// <param name="message"></param>
        public Notifications StringHasLength(string text, int minLength, int maxLength, string property, string message)
        {
            if (!Checks.ZionCheck.StringHasLength(text, minLength, maxLength))
                AddNotification(property, message);
            return this;
        }
    }
}
