using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zion.Common.ValueObjects;

namespace Zion.Common.Test.ValueObjects
{
    [TestClass]
    public class Email_Test
    {
        [TestMethod]
        public void Email_IsValid()
        {
            var tmp = new Email("laranja22@hotmail.com");
            Assert.IsNotNull(tmp);
            Assert.AreEqual("laranja22@hotmail.com", tmp.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Email_Invalid()
        {
            var tmp = new Email("abcde");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Email_Invalid_Null()
        {
            var tmp = new Email(null);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Email_Invalid_Empty()
        {
            var tmp = new Email(string.Empty);
        }
    }
}
