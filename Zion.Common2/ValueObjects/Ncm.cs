namespace Zion.Common2.ValueObjects
{
    public class Ncm
    {
        /// <summary>
        /// I05 - Código NCM com 8 dígitos
        /// Obrigatória informação do NCM completo (8 dígitos).
        /// Nota: Em caso de item de serviço ou item que não tenham produto(ex.transferência de crédito, crédito do ativo imobilizado, etc.), informar o valor 00 (dois zeros). (NT 2014/004)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsValid(string value)
        {
            try
            {
                Assertions.ZionAssertion.ObjectIsNull(value, "NCm Inválido");
                Assertions.ZionAssertion.StringHasMinLen(value, 2, "Ncm Inválido");
                Assertions.ZionAssertion.StringHasMaxLen(value, 8, "Ncm Inválido");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
