using OpenQA.Selenium;
using Diploma.Helpers.Configuration;
using Diploma.Pages;
using Diploma.Steps;
using Allure.NUnit.Attributes;
using Allure.Net.Commons;

namespace Diploma.Tests.UITests
{
    public class PopupMessageTest : BaseUITest
    {
        [Test(Description = "Test for ")]
        [Category("Positive")]
        [AllureSeverity(SeverityLevel.normal)]
        public void PopupTest()
        {
            UserSteps userSteps = new UserSteps(Driver);
            ProjectsPage projectsPage = userSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
            projectsPage.MoveToPopupMessage();
            string tooltipText = Driver.FindElement(By.CssSelector("[data-content='Alek']")).Text;

            Assert.That(projectsPage.IsPopupVisible);
        }
    }
}