using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zion.Common2.ValueObjects;

namespace Zion.Common2.Test.ValueObjects
{
    [TestClass]
    public class CpfCnpj_Test
    {
        [TestMethod]
        public void CpfCnpj_Valid()
        {
            var tmp1 = new CpfCnpj("81820118762");
            var tmp2 = new CpfCnpj("81820118762");
            var tmp3 = new CpfCnpj("818.201.187-62");

            Assert.AreEqual(tmp1, tmp2);
            Assert.AreEqual(tmp2, tmp1);
            Assert.AreEqual(tmp2, tmp3);
            Assert.IsTrue(tmp2 == tmp3);

            tmp1 = null;
            Assert.AreNotEqual(tmp1, tmp2);
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void CpfCnpj_Invalid_81840118762()
        {
            new CpfCnpj("81840118762");
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void CpfCnpj_Invalid_0118762()
        {
            new CpfCnpj("0118762");
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void CpfCnpj_Invalid_838_201_187_62()
        {
            new CpfCnpj("838.201.187-62");
        }
    }
}
