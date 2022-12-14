using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace AllureExamples
{
    [TestFixture]
    [AllureNUnit]
    [AllureDisplayIgnored]
    public class AllureTests
    {
        [Test]
        public void Test1()
        {
        }

        [Test]
        public void Test2()
        {
        }

        [Test]
        public void TestWithException()
        {
            throw new Exception("Ordinary exception");
        }

        [Test]
        [AllureName("My custom name for test in allure")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.blocker)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("Yauheni Myshkavets")]
        [AllureSuite("Login functionality")]
        [AllureSubSuite("Login with incorrect email")]
        [AllureDescription("Description For This Test")]
        public void PrintHelloWorld()
        {
            Assert.AreEqual(4, 5);
        }

        [Test]
        [AllureName("My custom name for test in allure")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.minor)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("Yauheni Myshkavets")]
        [AllureSuite("Sending email functionality")]
        [AllureSubSuite("Login with incorrect email")]
        [AllureDescription("Description For This Test")]
        public void PrintHelloWorld2()
        {
            Assert.AreEqual(4, 5);
        }
    }
}