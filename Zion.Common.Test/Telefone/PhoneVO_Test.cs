using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zion.Common.ValueObjects;

namespace Zion.Common.Test.Telefone
{
    [TestClass]
    public class PhoneVO_Test
    {
        [TestMethod]
        public void PhoneValid()
        {
            var p1 = new Phone("21998772322");
            Assert.AreEqual(p1.Formatted, "(21)99877-2322");
            Assert.AreEqual(p1.Unformatted, "21998772322");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PhoneInvalid1()
        {
            var p1 = new Phone("21998712372322a");
        }
    }
}
