using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zion.Common.Validations;

namespace Zion.Common.Test.Validations_Tests
{
    [TestClass]
    public class PhoneValidation_Test
    {
        [TestMethod]
        public void TelefoneValid()
        {
            Assert.IsTrue(PhoneValidation.IsValid("(21)99877-2322"));
            Assert.IsTrue(PhoneValidation.IsValid("(21)99877-2322"));
            Assert.IsTrue(PhoneValidation.IsValid("2138358025"));
            Assert.IsTrue(PhoneValidation.IsValid("2138358025"));
            Assert.IsFalse(PhoneValidation.IsValid("000000"));
            Assert.IsFalse(PhoneValidation.IsValid("000000000000"));
            Assert.IsFalse(PhoneValidation.IsValid("000000AAAA"));
            Assert.IsFalse(PhoneValidation.IsValid(""));
            Assert.IsFalse(PhoneValidation.IsValid(string.Empty));
        }
    }
}
