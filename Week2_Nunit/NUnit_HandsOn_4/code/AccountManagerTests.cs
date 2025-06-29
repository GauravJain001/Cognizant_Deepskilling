using System;
using AccountsManagerLib;
namespace code
{
    public class AccountManagerTests
    {
        private AccountsManager Manager { get; set; }
        [SetUp]
        public void Setup()
        {
            Manager = new AccountsManager();

        }

        [Test]
        public void ValidateUser_ValidCredentials_RetunsWelcomeMessage()
        {
            string output = Manager.ValidateUser("user_11", "secret@user11");
            Assert.That("Welcome user_11!!!",Is.EqualTo(output));
        }
        [TestCase("user_11", "secret@user11", "Welcome user_11!!!")]
        [TestCase("user_22", "secret@user22", "Welcome user_22!!!")]
        public void ValidateUser_ValidateAllUsers_ReturnsCorrectWelcome(string username,string password,string expected)
        {
            string output = Manager.ValidateUser(username, password);
            Assert.That(output, Is.EqualTo(expected));

        }
        [Test]
        public void ValidateUser_EmptyInput_ReturnsFormatException()
        {
            try
            {
                string output = Manager.ValidateUser("", "secret@user11");
                Assert.Fail("Empty String Passed");
                Assert.That(output, Is.EqualTo("Welcome user_11!!!"));


            }
            catch (FormatException ex)
            {
                Assert.That("Both user id and password are mandatory",Is.EqualTo(ex.Message));
                //Assert.Fail("Empty String Passed");

            }
        }
        [Test]
        public void ValidateUser_InvalidCredentials_ReturnsInvalidMessage()
        {
            string output = Manager.ValidateUser("user33", "secret@user11");
            Assert.That("Invalid user id/password", Is.EqualTo(output));

        }


    }
}