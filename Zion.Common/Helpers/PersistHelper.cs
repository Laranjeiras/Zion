using System;
using System.Reflection;

namespace Zion.Common.Helpers
{
    public class PersistHelper
    {
        public static string StringToPersist(string valor, bool toUpperCase = false, int size = -1)
        {
            if (StringHelper.IsNullOrEmptyOrWhiteSpace(valor)) return null;

            valor = valor.TrimEnd().Trim().TrimStart();

            if (toUpperCase)
                valor = valor.ToUpper();
            if (size > 0)
                valor = StringHelper.AdjustString(valor, size);
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

        public object DBNullHandler(object instance)
        {
            if (instance != null)
                return instance;

            return DBNull.Value;
        }
    }
}
