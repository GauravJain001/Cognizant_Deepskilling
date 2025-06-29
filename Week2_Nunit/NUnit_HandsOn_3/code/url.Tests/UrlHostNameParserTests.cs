using NUnit.Framework;
using UtilLib; 

namespace url.Tests
{
    [TestFixture]
    public class UrlHostNameParserTests
    {
        private UrlHostNameParser parser;

        [SetUp]
        public void Setup()
        {
            parser = new UrlHostNameParser();
        }

        [Test]
        public void ParseHostName_HttpUrl_ReturnsHostName()
        {
            string url = "http://example.com/page";
            string result = parser.ParseHostName(url);
            Assert.That(result, Is.EqualTo("example.com"));
        }

        [Test]
        public void ParseHostName_HttpsUrl_ReturnsHostName()
        {
            string url = "https://openai.com/index.html";
            string result = parser.ParseHostName(url);
            Assert.That(result, Is.EqualTo("openai.com"));
        }

        [Test]
       
        public void ParseHostName_InvalidProtocol_ThrowsFormatException()
        {
            string url = "ftp://fileserver.com/downloads";

            try
            {
                parser.ParseHostName(url);

                Assert.Fail("Expected FormatException was not thrown.");
            }
            catch (FormatException ex)
            {
                // Check that the exception message is correct
                Assert.That(ex.Message, Is.EqualTo("Url is not in correct format"));
            }
        }
        [Test]
        public void ParseHostName_EmptyString_ThrowsIndexOutOfRange()
        {
            string url = "";

            try
            {
                parser.ParseHostName(url);
                Assert.Fail("Expected IndexOutOfRangeException was not thrown.");
            }
            catch (IndexOutOfRangeException ex)
            {
                Assert.Pass("Caught expected IndexOutOfRangeException");
            }
        }
        [Test]
        public void ParseHostName_MissingProtocol_ThrowsException()
        {
            string url = "openai.com/index.html";

            try
            {
                parser.ParseHostName(url);
                Assert.Fail("Expected IndexOutOfRangeException was not thrown.");
            }
            catch (IndexOutOfRangeException ex)
            {
                Assert.Pass("Caught expected IndexOutOfRangeException");
            }
        }
        [Test]
        public void ParseHostName_NullInput_ThrowsArgumentNullException()
        {
            string url = null;

            try
            {
                parser.ParseHostName(url);
                Assert.Fail("Expected ArgumentNullException was not thrown.");
            }
            catch (ArgumentNullException ex)
            {
                Assert.Pass("Caught expected ArgumentNullException");
            }
        }




    }
}
