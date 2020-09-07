using System;
using Zion.Common2.Helpers;

namespace Zion.Common2.Models
{
    public abstract class BaseProduto : BaseModel
    {
        protected BaseProduto()
        {

        }

        public BaseProduto(Guid idProduto, string descricao, string gtin, string ncm, string uCom, decimal comissao, string informacao)
        {
            IdProduto = idProduto;
            Descricao = descricao;
            Gtin = gtin;
            Ncm = ncm;
            UCom = uCom;
            Comissao = comissao;
            Informacoes = informacao;
        }

        public BaseProduto(Guid idProduto, string descricao, string ncm, string ucom)
        {
            IdProduto = idProduto;
            Descricao = descricao;
            Ncm = ncm;
            UCom = ucom;
        }

        public int Codigo { get; protected set; }
        public Guid IdProduto { get; protected set; } = Guid.NewGuid();
        public string Descricao { get; protected set; }
        public string Gtin { get; protected set; }
        public string Ncm { get; protected set; }
        public string UCom { get; protected set; }
        public decimal Comissao { get; protected set; }
        public string Informacoes { get; protected set; }
        public bool ExibirNaTabela { get; protected set; }
        public decimal QuantidadeEmbalagem { get; protected set; }

        public void DefinirNcm(string valor)
        {
            Assertions.ZionAssertion.ObjectIsNull(valor, "NCm Inválido");
            Assertions.ZionAssertion.StringHasMinLen(valor, 2, "Ncm Inválido");
            Assertions.ZionAssertion.StringHasMaxLen(valor, 8, "Ncm Inválido");
            Ncm = valor;
        }

        public void DefinirUCom(string valor)
        {
            if (!ValueObjects.UCom.IsValid(valor))
                throw new Exception("I09 Unidade Comercial - UCom inválida");
            UCom = valor;
        }

        public void DefinirGtin(string gtin)
        {
            Gtin = gtin;
        }

        public virtual bool Validar()
        {
            ZionHelper.ClassToPersist(this);
            Contract.RemoveAllNotifications();

            if (IdProduto == Guid.Empty)
                Contract.AddNotification("IdProduto", "IdProduto não informado");
            if (!Checks.ZionCheck.StringHasLength(Gtin, 0, 14))
                Contract.AddNotification("Gtin", "Gtin inválido");
            if (Checks.ZionCheck.StringIsNullOrEmptyOrWhiteSpace(Descricao))
                Contract.AddNotification("Descricao", "Descrição não informada");
            if (!Checks.ZionCheck.StringHasLength(Descricao, 1, 120))
                Contract.AddNotification("Descricao", "Descrição inválida");

            if (!ValueObjects.Ncm.IsValid(Ncm))
                Contract.AddNotification("Ncm", "Ncm inválido");
            //if (!(Zion.Common2.Checks.ZionCheck.StringHasLength(Ncm, 2, 2) || Zion.Common2.Checks.ZionCheck.StringHasLength(Ncm, 8, 8)))
            //    Validations.AddNotification("Ncm", "Ncm inválido");

            if (!ValueObjects.UCom.IsValid(UCom))
                Contract.AddNotification("UCom", "Unidade Comercial inválida");

            return Contract.Valid;
        }
    }
}
