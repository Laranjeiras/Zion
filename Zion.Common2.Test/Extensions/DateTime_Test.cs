using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Zion.Common2.Extensions;

namespace Zion.Common2.Test.Extensions
{
    [TestClass]
    public class DateTime_Test
    {
        private readonly DateTime DataBase = new DateTime(2019, 01, 01);

        [TestMethod]
        public void StartOfDay_Test()
        {
            var date = DataBase.StartOfDay();
            Assert.IsNotNull(date);
        }
    }
}
