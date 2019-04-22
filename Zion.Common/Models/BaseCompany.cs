using System;
using Zion.Common.Assertions;
using Zion.Common.ValueObjects;

namespace Zion.Common.Models
{
    public class Company
    {
        protected Company() 
        {

        }

        public Company(Guid guidCompany, CpfCnpj cnpj, string inscEst, string name, string socialName, Email email, Phone phone)
        {
            GuidCompany = guidCompany;
            Cnpj = cnpj;
            InscEst = inscEst;
            Name = name;
            SocialName = socialName;
            Email = email;
            Phone = phone;
            AssertValidation(this);
        }

        public Guid GuidCompany { get; protected set; } = Guid.NewGuid();
        public CpfCnpj Cnpj { get; protected set; }
        public string InscEst { get; protected set; }
        public string Name { get; protected set; }
        public string SocialName { get; protected set; }
        public Email Email { get; protected set; }
        public Phone Phone { get; protected set; }

        public static void AssertValidation(Company company)
        {
            ZionAssertion.StringIsNullOrEmptyOrWhiteSpace(company.Name, "Razão Social é de preenchimento obrigatório!");
            ZionAssertion.ObjectIsNull(company.Cnpj, "CNPJ é de preenchimento obrigatório");
            CpfCnpj.AssertValidation(company.Cnpj.Value, "CNPJ inválido");
            ZionAssertion.StringIsNullOrEmptyOrWhiteSpace(company.InscEst, "Inscrição Estadual é de preenchimento obrigatório");
            if (company.Email == null) throw new Exception("Email é de preenchimento obrigatório");
            if (company.Phone == null) throw new Exception("Telefone é de preenchimento obrigatório");
        }
    }
}
