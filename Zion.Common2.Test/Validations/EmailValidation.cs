using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Zion.Common2.Validations;

namespace Zion.Common2.Test.Validations
{
    [TestClass]
    public class EmailValidation
    {
        [TestMethod]
        public void EmailValid()
        {
            Assert.IsTrue(ZionValidation.EmailValidation("laranja22@hotmail.com"));
        }

        [TestMethod]
        public void EmailInvalid()
        {
            Assert.IsFalse(ZionValidation.EmailValidation("laranja22hotmail.com"));
            Assert.IsFalse(ZionValidation.EmailValidation(""));
            Assert.IsFalse(ZionValidation.EmailValidation(null));
        }
    }
}
