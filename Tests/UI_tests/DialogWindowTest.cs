using Diploma.Helpers.Configuration;
using Diploma.Pages;
using Diploma.Steps;
using Allure.NUnit.Attributes;
using Allure.Net.Commons;

namespace Diploma.Tests.UI_tests
{
    [AllureEpic("Web Interface")]
    [AllureFeature("Login feature", "AddProject feature")]
    public class DialogWindowTest : BaseTest
    {
        [Test(Description = "Проверка отображения диалогового окна")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureStory("Story4")]
        public void TestDialogWindow()
        {
            UserSteps userSteps = new UserSteps(Driver);
            ProjectsPage projectsPage = userSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
            projectsPage.ClickAddToProject();

            Assert.That(projectsPage.DialogWindowOpened);
        }
    }
}
   
