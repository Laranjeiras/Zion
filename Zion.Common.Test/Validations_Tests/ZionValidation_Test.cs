using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zion.Common.Validations;

namespace Zion.Common.Test.Validations_Tests
{
    [TestClass]
    public class ZionValidation_Test
    {
        [TestMethod]
        public void StringHasLen_Valid()
        {
            Assert.IsTrue(ZionValidation.StringHasLen("string", 6));
            Assert.IsTrue(ZionValidation.StringHasLen("string", 1, 6));
            Assert.IsTrue(ZionValidation.StringHasLen("a", 1));
            Assert.IsTrue(ZionValidation.StringHasLen(null, 0));
            Assert.IsTrue(ZionValidation.StringHasLen(null, 0, 10));
            Assert.IsTrue(ZionValidation.IsNullOrEmptyOrWhiteSpace(null));
            Assert.IsTrue(ZionValidation.IsNullOrEmptyOrWhiteSpace(""));
            Assert.IsTrue(ZionValidation.IsNullOrEmptyOrWhiteSpace("   "));
        }

        [TestMethod]
        public void StringHasLen_Invalid()
        {
            Assert.IsFalse(ZionValidation.StringHasLen("string", 5));
            Assert.IsFalse(ZionValidation.StringHasLen("", 0));
            Assert.IsFalse(ZionValidation.StringHasLen(null, 1, 5));
            Assert.IsFalse(ZionValidation.IsNullOrEmptyOrWhiteSpace("AAA"));
        }
    }
}
