using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zion.Common.Test.Helpers_Tests
{
    [TestClass]
    public class StringHelper_Test
    {
        [TestMethod]
        public void MaxLength_Null()
        {
            Assert.IsNull(Helpers.StringHelper.MaxLength(null, 10));
        }

        [TestMethod]
        public void MaxLength_Empty()
        {
            Assert.AreEqual(Helpers.StringHelper.MaxLength(string.Empty, 10), string.Empty);
        }

        [TestMethod]
        public void MaxLength_Abcdef_0_Empty() {
            Assert.AreEqual(Helpers.StringHelper.MaxLength("abcdef", 0), string.Empty);
        }

        [TestMethod]
        public void AdjustString_Abcdef_5_abcde()
        {
            Assert.AreEqual("abcde", Helpers.StringHelper.MaxLength("abcdef", 5));
            Assert.AreEqual("abcde", Helpers.StringHelper.MaxLength(" abcdef  ", 5));
        }
    }
}
