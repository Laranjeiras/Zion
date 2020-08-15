using System;
using System.Reflection;

namespace Zion.Common2.Helpers
{
    public partial class ZionHelper
    {
        public static string StringToPersist(string valor, bool toUpperCase = false, int size = -1)
        {
            if (ZionHelper.IsNullOrEmptyOrWhiteSpace(valor)) return null;

            valor = valor.Trim();

            if (toUpperCase)
                valor = valor.ToUpper();
            if (size > 0)
                valor = ZionHelper.MaxLength(valor, size);
            return valor;
        }

        public static void ClassToPersist(object obj, bool toUpperCase = false)
        {
            PropertyInfo[] properties = obj.GetType().GetProperties();
            foreach (var item in properties)
            {
                if (item.PropertyType == Type.GetType("System.String") && item.GetValue(obj, null) != null)
                {
                    var value = item.GetValue(obj, null);
                    item.SetValue(obj, StringToPersist(value.ToString(), toUpperCase));
                }
            }
        }

        public static object DBNullHandler(object instance)
        {
            if (instance != null)
                return instance;

            return DBNull.Value;
        }
    }
}
