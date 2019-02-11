using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zion.Common.Extensions;

namespace Zion.Common.Test.Extensions
{
    [TestClass]
    public class String_Test
    {
        [TestMethod]
        public void StringHasLen_True()
        {
            Assert.IsTrue("arg".HasLen(3));
        }

        [TestMethod]
        public void StringHasLen_Fase()
        {
            Assert.IsFalse("arg".HasLen(4));
        }
    }
}
