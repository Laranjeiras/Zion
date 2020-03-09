using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zion.Common2.Validations;

namespace Zion.Common2.Test.Validations
{
    [TestClass]
    public class StringValidation
    {
        [TestMethod]
        public void StringIsNullOrEmptyOrWhiteSpace() {
            Assert.IsTrue(ZionValidation.StringIsNullOrEmptyOrWhiteSpace(""));
            Assert.IsTrue(ZionValidation.StringIsNullOrEmptyOrWhiteSpace(null));
            Assert.IsTrue(ZionValidation.StringIsNullOrEmptyOrWhiteSpace("     "));
            Assert.IsFalse(ZionValidation.StringIsNullOrEmptyOrWhiteSpace("aa"));
        }

        [TestMethod]
        public void StringHasLen() 
        {
            Assert.IsTrue(ZionValidation.StringHasLength("aaa", 3, 3));
            Assert.IsFalse(ZionValidation.StringHasLength("aaaa", 3, 3));
            Assert.IsTrue(ZionValidation.StringHasLength(null, 0, 3));
            Assert.IsFalse(ZionValidation.StringHasLength(null, 1, 60));            
        }
    }
}
