using System;

namespace Zion.Common2.Validations
{
    public partial class ZionValidation
    {
        public static bool IsNullOrEmpty(Guid? guid)
        {
            if (guid == null || guid == Guid.Empty)
                return true;
            return false;
        }
    }
}
