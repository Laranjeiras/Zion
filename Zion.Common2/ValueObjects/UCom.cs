namespace Zion.Common2.ValueObjects
{
    public static class UCom
    {
        // "I09 - Unidade Comercial - Unidade Comercial inválida, deve conter entre 1 e 6 caracteres"
        public static bool IsValid(string value)
        {
            if (Common2.Checks.ZionCheck.StringHasLength(value, 1, 6))
                return true;
            return false;
        }
    }
}
