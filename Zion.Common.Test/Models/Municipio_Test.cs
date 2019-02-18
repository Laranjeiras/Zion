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
            var mun = new Municipio(3302700,"Maricá", new UF(33,"RJ", "Rio de Janeiro"));
            Assert.IsNotNull(mun);
        }
    }

    public class Municipio : BaseMunicipio
    {
        public Municipio(int idMunicipio, string nome, BaseUF uf) : base(idMunicipio, nome, uf)
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
