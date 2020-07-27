using System;

namespace Zion.Common2.Checks
{
    public partial class ZionCheck
    {
        public static bool IsNullOrEmpty(Guid? guid)
        {
            if (guid == null || guid == Guid.Empty)
                return true;
            return false;
        }
    }
}
