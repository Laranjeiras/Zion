using System;

namespace Zion.Common2.Assertions
{
    public partial class ZionAssertion
    {
        public static void StringIsNullOrEmptyOrWhiteSpace(string value, string message = "NullOrEmptyOrWhiteSpace")
        {
            if(Common2.Checks.ZionCheck.StringIsNullOrEmptyOrWhiteSpace(value))
                throw new Exception(message);
        }

        public static void StringHasLen(string value, int len, string message = "Invalid Len")
        {
            if (value == null) return;

            if (!Common2.Checks.ZionCheck.StringHasLength(value,len,len))           
                throw new Exception(message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="minLength">Se informar valor 0, aceitará valores nullos</param>
        /// <param name="maxLength"></param>
        /// <param name="message"></param>
        public static void StringHasLen(string value, int minLength, int maxLength, string message = "Invalid Length")
        {
            if(!Common2.Checks.ZionCheck.StringHasLength(value, minLength, maxLength))
                throw new Exception(message);
        }

        public static void StringHasMinLen(string value, int minLength, string message="Invalid HasMinLen") 
        {
            if(!Common2.Checks.ZionCheck.StringHasMinLen(value, minLength))
                throw new Exception(message);
        }

        public static void StringHasMaxLen(string value, int maxLength, string message="Invalid HasMaxLen") 
        {
            if (!Common2.Checks.ZionCheck.StringHasMaxLen(value, maxLength))
                throw new Exception(message);
        }
    }
}
