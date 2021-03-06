﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Zion.Common.Assertions;

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
            ZionAssertion.ObjectIsNull(t);
        }

        [TestMethod]
        public void PhoneNumberIsValid_Valid()
        {
            ZionAssertion.PhoneNumberIsValid("21998772322");
            ZionAssertion.PhoneNumberIsValid("2122222222");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PhoneNumberIsValid_21()
        {
            ZionAssertion.PhoneNumberIsValid("21");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PhoneNumberIsValid_Null()
        {
            ZionAssertion.PhoneNumberIsValid(null);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PhoneNumberIsValid_Empty()
        {
            ZionAssertion.PhoneNumberIsValid(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PhoneNumberIsValid_WhiteSpace()
        {
            ZionAssertion.PhoneNumberIsValid("   ");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void StringHasLen_Invalid()
        {
            ZionAssertion.StringHasLen("string", 5);
        }

        [TestMethod]
        public void StringHasLen_Valid()
        {
            ZionAssertion.StringHasLen("string", 6);
        }

        [TestMethod]
        public void StringHasLen_MinAndMax_Valid()
        {
            ZionAssertion.StringHasLen("string", 5, 6);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void StringHasLen_MinAndMax_Invalid()
        {
            ZionAssertion.StringHasLen("string", 2, 4);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void StringHasMinLen_Valid()
        {
            ZionAssertion.StringHasMinLen("a", 2);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void StringHasMaxLen_Valid()
        {
            ZionAssertion.StringHasLen("string", 5);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void StringIsNullOrEmptyOrWhiteSpace_Whitespace()
        {
            ZionAssertion.StringIsNullOrEmptyOrWhiteSpace("   ");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void StringIsNullOrEmptyOrWhiteSpace_Null()
        {
            ZionAssertion.StringIsNullOrEmptyOrWhiteSpace(null);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void StringIsNullOrEmptyOrWhiteSpace_Empty()
        {
            ZionAssertion.StringIsNullOrEmptyOrWhiteSpace(string.Empty);
        }

        #region Numeric

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NumericIsBiggerThen_Decimal_Fail()
        {
            ZionAssertion.IsBiggerThen(2.0m, 5.0m);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NumericIsBiggerThen_Long_Fail()
        {
            ZionAssertion.IsBiggerThen(2, 5);
        }

        [TestMethod]
        public void NumericIsBiggerThen_Decimal_Ok()
        {
            ZionAssertion.IsBiggerThen(2.0m, 1.0m);
        }

        [TestMethod]
        public void NumericIsBiggerThen_Long_OK()
        {
            ZionAssertion.IsBiggerThen(2, 1);
        }
        #endregion
    }
}
