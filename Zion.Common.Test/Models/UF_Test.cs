using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zion.Common.Test.Models
{
    [TestClass]
    public class UF_Test
    {
        [TestMethod]
        public void UF_New()
        {
            var uf = new UF(33, "RJ", "Rio de Janeiro");
            Assert.IsNotNull(uf);
        }
    }
}
