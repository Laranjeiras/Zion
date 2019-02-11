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
            Assert.IsTrue(ZionValidation.StringHasLen("a", 1));
            Assert.IsTrue(ZionValidation.StringHasLen(null, 0));
        }

        [TestMethod]
        public void StringHasLen_Invalid()
        {
            Assert.IsFalse(ZionValidation.StringHasLen("string", 5));
            Assert.IsFalse(ZionValidation.StringHasLen("", 0));
        }
    }
}
