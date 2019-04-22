using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Zion.Common.Models;
using Zion.Common.ValueObjects;

namespace Zion.Common.Test.Models
{
    [TestClass]
    public class Company_Test
    {
        [TestMethod]
        public void Company_Model()
        {
            var guidCompany = new Guid("4ef1926b-6327-4b9d-9e7a-4d407ca326b3");
            var cnpj = new CpfCnpj("27.865.757/0001-02");
            var insc = "84.295.76-0";
            var name = "GLOBO COMUNICACAO E PARTICIPACOES S/A";
            var socialName = "GCP,TV GLOBO, REDE GLOBO, GLOBO.COM, SOM LIVRE";
            var email = new Email("globog1.com.br");
            var phone = new Phone("2140022884");



            var comp = new Company(guidCompany, cnpj, insc, name, socialName, email, phone);
        }
    }
}
