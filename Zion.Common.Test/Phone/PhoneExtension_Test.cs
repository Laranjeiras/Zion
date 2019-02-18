using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zion.Common.Extensions;

namespace Zion.Common.Test.Telefone
{
    [TestClass]
    public class PhoneExtension_Test
    {
        [TestMethod]
        public void Format()
        {
            var phoneNumber = "21998772322".PhoneFormat();
            Assert.AreEqual(phoneNumber, "(21)99877-2322");
        }
    }
}