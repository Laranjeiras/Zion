namespace Zion.Common2.Checks
{
    public partial class ZionCheck
    {
        public static bool StringIsNullOrEmptyOrWhiteSpace(string value)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                return true;
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="minLength">If minLength = 0 return true if null</param>
        /// <param name="maxLength"></param>
        /// <param name="message"></param>
        public static bool StringHasLength(string value, int minLength, int maxLength)
        {
            if (value == null && minLength == 0) return true;
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) return false;

            if (value.Length < minLength || value.Length > maxLength)
                return false;
            return true;
        }

        public static bool StringHasMinLen(string value, int minLength)
        {
            if (string.IsNullOrEmpty(value) || value.Length < minLength)
                return false;
            return true;
        }

        public static bool StringHasMaxLen(string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value) || value.Length > maxLength)
                return false;
            return true;
        }
    }
}
