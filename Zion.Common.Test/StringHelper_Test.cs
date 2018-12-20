using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zion.Common.Helpers;

namespace Zion.Common.Test
{
    [TestClass]
    public class StringHelper_Test
    {
        [TestMethod]
        public void MaxLength()
        {
            var baseStr = " ABCDEFGHIJKLM ";
            Assert.AreEqual("ABCDEFGHIJ", StringHelper.MaxLength(baseStr, 10));
            Assert.AreEqual("", StringHelper.MaxLength(baseStr, 0));
            Assert.IsNull(StringHelper.MaxLength(null, 10));
            Assert.AreEqual(baseStr, StringHelper.MaxLength(baseStr, 100, false));
        }
    }
}
