using Allure.Net.Commons;
using NUnit.Framework.Interfaces;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Allure.Core;

namespace AllureExamples
{
    [TestFixture]
    [AllureNUnit]
    public class AllureScreenShot
    {
        private IWebDriver _driver;

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://www.google.com/");
        }

        [Test]
        public void ScreenShotTest()
        {
            var googleApps = _driver.FindElement(By.XPath("//a[@aria-label='Google apps']"));
            var isGoogleAppsDisplayed = googleApps.Displayed;
            Assert.IsFalse(isGoogleAppsDisplayed);
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                var screenShot = ((ITakesScreenshot)_driver).GetScreenshot().AsByteArray;
                AllureLifecycle.Instance.AddAttachment(TestContext.CurrentContext.Test.Name, "image/png", screenShot);
            }
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _driver.Quit();
        }
    }
}
