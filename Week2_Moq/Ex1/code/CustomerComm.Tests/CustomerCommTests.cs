using code;
using Moq;
using NUnit.Framework;

namespace CustomerCommTests
{
    [TestFixture]
    public class CustomerCommTests
    {
        private Mock<IMailSender> _mockMailSender;
        private CustomerComm _customerComm;

        [OneTimeSetUp]
        public void Setup()
        {
            // Arrange: mock IMailSender to always return true
            _mockMailSender = new Mock<IMailSender>();
            _mockMailSender
                .Setup(m => m.SendMail(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(true);

            _customerComm = new CustomerComm(_mockMailSender.Object);
        }

        [TestCase]
        public void SendMailToCustomer_ReturnsTrue_WhenMailIsSent()
        {
            // Act
            bool result = _customerComm.SendMailToCustomer();

            // Assert
            Assert.IsTrue(result);
        }
    }
}
