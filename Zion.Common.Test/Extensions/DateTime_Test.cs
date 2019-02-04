using System;
using Zion.Common.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zion.Common.Test.Extensions
{
    [TestClass]
    public class DateTime_Test
    {
        private readonly DateTime DataBase = new DateTime(2019, 01, 01);

        [TestMethod]
        public void StartOfWeek_Sunday()
        {
            var inicio = DataBase.StartOfWeek(DayOfWeek.Sunday);
            var dataEsperada = new DateTime(2018, 12, 30);
            Assert.AreEqual(dataEsperada, inicio);
        }

        [TestMethod]
        public void StartOfWeek_Monday()
        {
            var inicio = DataBase.StartOfWeek(DayOfWeek.Monday);
            var dataEsperada = new DateTime(2018, 12, 31);
            Assert.AreEqual(dataEsperada, inicio);
        }

        [TestMethod]
        public void EndOfWeek_Sunday()
        {
            var final = DataBase.EndOfWeek(DayOfWeek.Sunday);
            var dataEsperada = new DateTime(2019, 01, 06);
            Assert.AreEqual(dataEsperada, final);
        }

        [TestMethod]
        public void EndOfWeek_Saturday()
        {
            var final = DataBase.EndOfWeek(DayOfWeek.Saturday);
            var dataEsperada = new DateTime(2019, 01, 05);
            Assert.AreEqual(dataEsperada, final);
        }
    }
}
