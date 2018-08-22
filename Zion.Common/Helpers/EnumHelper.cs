using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace Zion.Common.Helpers
{
    public class EnumHelper
    {
        public static IList<(int Value, string Text)> GetList(Type enumType)
        {
            if (!enumType.IsEnum)
                throw new InvalidOperationException();

            IList<(int, string)> list = new List<(int, string)>();

            Type typeDescription = typeof(DescriptionAttribute);
            FieldInfo[] fields = enumType.GetFields();

            foreach (FieldInfo field in fields)
            {
                if (!field.FieldType.IsEnum)
                    continue;

                int value = (int)enumType.InvokeMember(field.Name, BindingFlags.GetField, null, null, null);

                object[] array = field.GetCustomAttributes(typeDescription, false);

                var text = array.Length > 0 ? ((DescriptionAttribute)array[0]).Description : field.Name;

                list.Add((value, text));
            }
            return list;
        }

        public static T GetAtrributeOfType<T>(Enum valueEnum) where T : System.Attribute
        {
            var type = valueEnum.GetType();
            var memInfo = type.GetMember(valueEnum.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(T), false);
            return (attributes.Length > 0) ? (T)attributes[0] : null;
        }

        public static string GetDescription(Enum valueEnum)
        {
            return GetAtrributeOfType<DescriptionAttribute>(valueEnum).Description;
        }

    }
}
