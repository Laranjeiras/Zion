using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zion.Common.Validations;

namespace Zion.Common.Test
{
    [TestClass]
    public class InscricaoEstadualValidation_Test
    {
        [TestMethod]
        public void Validar_AC()
        {
            Assert.IsTrue(InscricaoEstadualValidation.IsValid(Enums.eUF.AC, "01.368.945/191-39"));
            Assert.IsTrue(InscricaoEstadualValidation.IsValid(Enums.eUF.AC, "01.043.519/597-09"));
        }

        [TestMethod]
        public void Validar_AL()
        {
            Assert.IsTrue(InscricaoEstadualValidation.IsValid(Enums.eUF.AL, "248102656"));
            Assert.IsTrue(InscricaoEstadualValidation.IsValid(Enums.eUF.AL, "2482096810"));
        }

        /// <summary>
        /// Funcionando
        /// </summary>
        [TestMethod]
        public void Validar_RJ()
        {
            Assert.IsTrue(InscricaoEstadualValidation.IsValid(Enums.eUF.RJ, "42.919.59-4"));
            Assert.IsTrue(InscricaoEstadualValidation.IsValid(Enums.eUF.RJ, "79.460.508"));
            Assert.IsFalse(InscricaoEstadualValidation.IsValid(Enums.eUF.RJ, "432.919.59-4"));
            Assert.IsFalse(InscricaoEstadualValidation.IsValid(Enums.eUF.RJ, "739.460.508"));
            Assert.IsFalse(InscricaoEstadualValidation.IsValid(Enums.eUF.RJ, "02.919.59-4"));
        }
    }
}
