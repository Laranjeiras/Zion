using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zion.Common.Test.Assertions
{
    [TestClass]
    public class ZionAssertion_Test
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ObjectIsNull()
        {
            string t = null;
            Zion.Common.Assertions.ZionAssertion.ObjectIsNull(t);
        }

        [TestMethod]
        public void PhoneNumberIsValid_Valid()
        {
            Zion.Common.Assertions.ZionAssertion.PhoneNumberIsValid("21998772322");
            Zion.Common.Assertions.ZionAssertion.PhoneNumberIsValid("2122222222");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PhoneNumberIsValid_21()
        {
            Zion.Common.Assertions.ZionAssertion.PhoneNumberIsValid("21");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PhoneNumberIsValid_Null()
        {
            Zion.Common.Assertions.ZionAssertion.PhoneNumberIsValid(null);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PhoneNumberIsValid_Empty()
        {
            Zion.Common.Assertions.ZionAssertion.PhoneNumberIsValid(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PhoneNumberIsValid_WhiteSpace()
        {
            Zion.Common.Assertions.ZionAssertion.PhoneNumberIsValid("   ");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void StringIsNullOrEmptyOrWhiteSpace_Whitespace()
        {
            Zion.Common.Assertions.ZionAssertion.StringIsNullOrEmptyOrWhiteSpace("   ");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void StringIsNullOrEmptyOrWhiteSpace_Null()
        {
            Zion.Common.Assertions.ZionAssertion.StringIsNullOrEmptyOrWhiteSpace(null);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void StringIsNullOrEmptyOrWhiteSpace_Empty()
        {
            Zion.Common.Assertions.ZionAssertion.StringIsNullOrEmptyOrWhiteSpace(string.Empty);
        }
    }
}
