using System;
using Zion.Common2.NotificationPattern;

namespace Zion.Common2.Extensions
{
    public static class ContractExtension
    {
        public static Contract MergeContract(this Contract contractDestination, Contract contractSpurce)
        {
            if (contractSpurce == null)
                throw new ArgumentNullException("MergeContract received null values");

            contractDestination.AddNotifications(contractSpurce.Notifications);

            return contractDestination;
        }
    }
}
