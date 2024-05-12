using Allure.Net.Commons;
using NUnit.Allure.Core;
using Diploma.Core;
using Diploma.Helpers;
using Diploma.Helpers.Configuration;
using Diploma.Steps;
using OpenQA.Selenium;
using Allure.NUnit.Attributes;
using NLog;

namespace Diploma.Tests.UITests
{
    [Parallelizable(scope: ParallelScope.All)]
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    [AllureNUnit, AllureOwner("QA")]
    public class BaseUITest
    {
        protected IWebDriver Driver { get; private set; }
        protected WaitsHelper WaitsHelper { get; private set; }
        protected UserSteps UserSteps;
        protected AllureSteps AllureSteps;
        protected static readonly Logger Logger = LogManager.GetCurrentClassLogger();

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
            try
            {
                if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
                {
                    Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                    byte[] screenshotBytes = screenshot.AsByteArray;
                    AllureApi.AddAttachment("Screenshot", "image/png", screenshotBytes);
                }
            }
            catch (Exception) { throw; }
            Driver.Quit();
        }
    }
}