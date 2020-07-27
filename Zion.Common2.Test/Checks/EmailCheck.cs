using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zion.Common2.Checks;

namespace Zion.Common2.Test.Checks
{
    [TestClass]
    public class EmailCheck
    {
        [TestMethod]
        public void EmailValid()
        {
            Assert.IsTrue(ZionCheck.EmailValidation("laranja22@hotmail.com"));
        }

        [TestMethod]
        public void EmailInvalid()
        {
            Assert.IsFalse(ZionCheck.EmailValidation("laranja22hotmail.com"));
            Assert.IsFalse(ZionCheck.EmailValidation(""));
            Assert.IsFalse(ZionCheck.EmailValidation(null));
        }
    }
}
