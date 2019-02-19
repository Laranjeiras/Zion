using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zion.Common.Models;

namespace Zion.Common.Test.Models
{
    [TestClass]
    public class Municipio_Test
    {
        [TestMethod]
        public void Municipio_New()
        {
            var mun = new Municipality(3302700,"Maricá", new UF(33,"RJ", "Rio de Janeiro"));
            Assert.IsNotNull(mun);
        }
    }

    public class Municipality : BaseMunicipality
    {
        public Municipality(int idMunicipality, string nome, BaseUF uf) : base(idMunicipality, nome, uf)
        {
        }
    }

    public class UF : BaseUF
    {
        public UF(int idUF, string sigla, string nome) : base(idUF, sigla, nome)
        {
        }
    }
}
