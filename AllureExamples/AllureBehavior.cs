using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace AllureExamples
{
    [TestFixture]
    [AllureNUnit]
    public class AllureBehavior
    {
        [Test]
        [AllureEpic("Tests for core functionality")]
        [AllureFeature("Login tests")]
        [AllureStory("Login with invalid email")]
        public void Test1()
        {
        }

        [Test]
        [AllureEpic("Tests for core functionality")]
        [AllureFeature("Login tests")]
        [AllureStory("Login with invalid password")]
        public void Test2()
        {
        }

        [Test]
        [AllureEpic("Tests for core functionality")]
        [AllureFeature("Sending email tests")]
        [AllureStory("Send email for one address")]
        public void Test3()
        {
        }

        [Test]
        [AllureEpic("Tests for core functionality")]
        [AllureFeature("Sending email tests")]
        [AllureStory("Send email for several address")]
        public void Test4()
        {
        }
    }
}
