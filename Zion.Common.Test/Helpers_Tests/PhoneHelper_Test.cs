using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zion.Common.Helpers;

namespace Zion.Common.Test.Helpers_Tests
{
    [TestClass]
    public class PhoneHelper_Test
    {
        [TestMethod]
        public void Format()
        {
            Assert.AreEqual(PhoneHelper.Format("21998772322"),"(21)99877-2322");
            Assert.AreEqual(PhoneHelper.Format("2138358025"), "(21)3835-8025");
        }
    }
}
