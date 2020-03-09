using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Zion.Common2.ValueObjects;

namespace Zion.Common2.Test.ValueObjects
{
    [TestClass]
    public class Email_Test
    {
        [TestMethod]
        public void EmailValid()
        {
            new Email("laranja22@hotmail.com");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void EmailInvalid_1()
        {
            new Email("laranja22hotmail.com");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void EmailInvalid_2()
        {
            new Email("");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void EmailInvalid_3()
        {
            new Email(null);
        }

    }
}
