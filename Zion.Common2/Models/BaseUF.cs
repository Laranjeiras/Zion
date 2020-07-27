namespace Zion.Common2.Models
{
    public abstract class BaseUF
    {
        protected BaseUF()
        {

        }

        public BaseUF(int idUf, string sigla, string nome)
        {
            Zion.Common2.Assertions.ZionAssertion.StringHasLen(sigla, 2, "Sigla inválida");
            IdUF = idUf;
            Sigla = Zion.Common2.Helpers.ZionHelper.MaxLength(sigla, 2);
            Nome = Zion.Common2.Helpers.ZionHelper.MaxLength(nome, 20);
        }

        public int IdUF { get; protected set; }
        public string Sigla { get; protected set; }
        public string Nome { get; protected set; }
    }
}
