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

        [TestMethod]
        public void Between_Null_src() 
        {
            Assert.AreEqual(string.Empty, Helpers.StringHelper.Between(null, "a", "z"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Between_Null_start()
        {
            Assert.AreEqual(string.Empty, Helpers.StringHelper.Between("abcdefghijklmnopqrstuvxyz", null, "z"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Between_Null_end()
        {
            Assert.AreEqual(string.Empty, Helpers.StringHelper.Between("abcdefghijklmnopqrstuvxyz", "a", null));
        }

        [TestMethod]
        public void Between_empty_Ad()
        {
            Assert.AreEqual(string.Empty, Helpers.StringHelper.Between("abcdefghijklmnopqrstuvxyz", "A", "d"));
        }

        [TestMethod]
        public void Between_def()
        {
            Assert.AreEqual("e", Helpers.StringHelper.Between("abcdefghijklmnopqrstuvxyz", "d", "f"));
            Assert.AreEqual("bc", Helpers.StringHelper.Between("abcdefghijklmnopqrstuvxyz", "a", "d"));
        }
    }
}
