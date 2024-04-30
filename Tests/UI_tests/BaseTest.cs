/*using Allure.Net.Commons;
using NUnit.Allure.Core;
using Diploma.Core;
using Diploma.Helpers;
using Diploma.Helpers.Configuration;
using Diploma.Steps;
using OpenQA.Selenium;

namespace Diploma.Tests.UI_tests
{
    [Parallelizable(scope: ParallelScope.All)]
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    [AllureNUnit]
    public class BaseTest
    {
        protected IWebDriver Driver { get; private set; }
        protected WaitsHelper WaitsHelper { get; private set; }
        protected UserSteps UserSteps;
        protected AllureSteps AllureSteps;

        [OneTimeSetUp]
        public static void GlobalSetup()
        {
            AllureLifecycle.Instance.CleanupResultDirectory();
        }

        [SetUp]
        public void FactoryDriverTest()
        {
            Driver = new Browser().Driver;
            WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
            AllureSteps = new AllureSteps(Driver);
            UserSteps = new UserSteps(Driver);

            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                byte[] screenshotBytes = screenshot.AsByteArray;

                AllureApi.AddAttachment("Screenshot", "image/png", screenshotBytes);
            }
            Driver.Quit();
        }
    }
}*/