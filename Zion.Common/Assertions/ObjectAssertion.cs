using System;

namespace Zion.Common.Assertions
{
    public partial class ZionAssertion
    {
        public static void ObjectIsNull(object value, string message = "Object is Null")
        {
            if (value == null)
                throw new Exception(message);
        }
    }
}
