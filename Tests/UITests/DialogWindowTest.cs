using Diploma.Helpers.Configuration;
using Diploma.Pages;
using Diploma.Steps;
using Allure.NUnit.Attributes;
using Allure.Net.Commons;

namespace Diploma.Tests.UITests
{
    public class DialogWindowTest : BaseUITest
    {
        [Test(Description = "Проверка отображения диалогового окна")]
        [AllureFeature("Positive")]
        [AllureSeverity(SeverityLevel.normal)]
        public void TestDialogWindow()
        {
            UserSteps userSteps = new UserSteps(Driver);
            ProjectsPage projectsPage = userSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
            projectsPage.ClickAddToProject();

            Assert.That(projectsPage.DialogWindowOpened);
        }
    }
}