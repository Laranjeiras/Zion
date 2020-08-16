using System;

namespace Zion.Common2.NotificationPattern
{
    public static class ContractExtension
    {
        public static Contract MergeContract(this Contract contractDestino, Contract contractOrigem)
        {
            if (contractOrigem == null)
                throw new ArgumentNullException("MergeContract received null values");

            contractDestino.AddNotifications(contractOrigem.Notifications);
            return contractDestino;
        }
    }
}
