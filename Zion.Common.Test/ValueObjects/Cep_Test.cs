using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zion.Common.ValueObjects;

namespace Zion.Common.Test.ValueObjects
{
    [TestClass]
    public class Cep_Test
    {
        [TestMethod]
        public void Cep_21000000_Valid()
        {
            var cep = new Cep("21000-000");
            Assert.AreEqual("21000000", cep.Simple);
            Assert.AreEqual("21000-000", cep.Formatted);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Cep_210000000_Invalid()
        {
            var cep = new Cep("210000-000");
        }
    }
}
