using System;
using System.Collections.Generic;

namespace Zion.Common.Extensions
{
    public partial class ZionExtensions
    {
        public static IList<(int Value, string Text)> GetList(this Type enumType)
        {
            return Helpers.EnumHelper.GetList(enumType);
        }

        public static T GetAtrributeOfType<T>(this Enum valueEnum) where T : Attribute
        {
            return Helpers.EnumHelper.GetAtrributeOfType<T>(valueEnum);
        }

        public static string GetDescription(this Enum valueEnum)
        {
            return Helpers.EnumHelper.GetDescription(valueEnum);
        }
    }
}