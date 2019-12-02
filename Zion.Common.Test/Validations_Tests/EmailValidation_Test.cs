using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zion.Common.Assertions;
using Zion.Common.Validations;

namespace Zion.Common.Test.Validations_Tests
{
    [TestClass]
    public class EmailValidation_Test
    {
        [TestMethod]
        public void Email_Invalid()
        {
            string[] emails = { "@majjf.com", "A@b@c@example.com", "Abc.example.com", "js*@proseware.com", "js@proseware..com", "ma@@jjf.com",
                                "ma@jjf.", "ma@jjf..com", "ma@jjf.c", "ma_@jjf", "ma_@jjf.","-------","j@proseware.com9","js#internal@proseware.com","js@proseware.com9",
                                "js@proseware.com9", "ma@hostname.comcom", "MA@hostname.coMCom"};
            foreach (var email in emails)
            {
                System.Console.WriteLine("Validando ==>" + email);
                Assert.IsFalse(ZionValidation.EmailValidation(email));
            }
        }

        [TestMethod]
        public void Email_Valid()
        {
            string[] emails = { "j.s@proseware.com", "j@server1.proseware.com" , "ma.ma@jjf.co", "ma_@jjf.com", "12@hostname.com", "d.j@server1.proseware.com",
                                "david.jones@proseware.com", "j.s@server1.proseware.com", "jones@ms1.proseware.com", "m.a@hostname.co", "m_a1a@hostname.com",
                                "ma.h.saraf.onemore@hostname.com.edu","ma@hostname.com","ma12@hostname.com","ma-a.aa@hostname.com.edu","ma-a@hostname.com","ma-a@hostname.com.edu",
                                "ma-a@1hostname.com","ma.a@1hostname.com","ma@1hostname.com" };

            foreach (var email in emails)
            {
                Assert.IsTrue(ZionValidation.EmailValidation(email),email);
            }

        }
    }
}
