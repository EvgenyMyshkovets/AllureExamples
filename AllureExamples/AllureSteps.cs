using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace AllureExamples
{
    [TestFixture]
    [AllureNUnit]
    public class AllureSteps
    {
        [Test]
        [AllureTag("NUnit", "Debug")]
        [AllureIssue("GitHub#1", "https://github.com/unickq/allure-nunit")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureFeature("Core")]
        [AllureId(123)]
        public void StepsTest()
        {
            FirstStep();
            SecondStep();

            AllureLifecycle.Instance.WrapInStep(() =>
            {
                Assert.AreEqual(2, 2);
            }, "Third step");
        }

        [AllureStep("This is first step")]
        private void FirstStep()
        {
            Console.WriteLine("Hello!");
            FirstSubStepInFirstStep();
            SecondSubStepInFirstStep();
        }

        [AllureStep("This is sub step is first step")]
        private void FirstSubStepInFirstStep()
        {
            Console.WriteLine("Hello in sub step!");
        }

        [AllureStep("This is sub step is first step")]
        private void SecondSubStepInFirstStep()
        {
            Console.WriteLine("Second Hello in sub step!");
        }

        [AllureStep("This is second step")]
        private void SecondStep()
        {
            Console.WriteLine("Hello in second step!");
        }
    }
}
