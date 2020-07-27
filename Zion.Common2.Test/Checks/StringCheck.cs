using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zion.Common2.Checks;

namespace Zion.Common2.Test.Checks
{
    [TestClass]
    public class StringCheck
    {
        [TestMethod]
        public void StringIsNullOrEmptyOrWhiteSpace() {
            Assert.IsTrue(ZionCheck.StringIsNullOrEmptyOrWhiteSpace(""));
            Assert.IsTrue(ZionCheck.StringIsNullOrEmptyOrWhiteSpace(null));
            Assert.IsTrue(ZionCheck.StringIsNullOrEmptyOrWhiteSpace("     "));
            Assert.IsFalse(ZionCheck.StringIsNullOrEmptyOrWhiteSpace("aa"));
        }

        [TestMethod]
        public void StringHasLen() 
        {
            Assert.IsTrue(ZionCheck.StringHasLength("aaa", 3, 3));
            Assert.IsFalse(ZionCheck.StringHasLength("aaaa", 3, 3));
            Assert.IsTrue(ZionCheck.StringHasLength(null, 0, 3));
            Assert.IsFalse(ZionCheck.StringHasLength(null, 1, 60));            
        }
    }
}
