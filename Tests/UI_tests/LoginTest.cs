using Diploma.Helpers.Configuration;
using Diploma.Pages;
using Diploma.Steps;
using Allure.NUnit.Attributes;
using Allure.Net.Commons;

namespace Diploma.Tests.UI_tests
{
    [AllureEpic("Web Interface")]
    [AllureFeature("Login feature")]

    public class LoginTest : BaseTest
    {
        [Test(Description = "Проверка перехода на главную страницу после логина с корректными данными")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureStory("Story1")]
        public void LoginWithStandardUser()
        {
            UserSteps userSteps = new UserSteps(Driver);
            ProjectsPage projectsPage = userSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

            Assert.That(projectsPage.IsPageOpened);
        }

        [Test(Description = "Проверка отображения ошибки")]
        [AllureSeverity(SeverityLevel.blocker)]
        [AllureStory("Story1")]
        public void LoginWithErrorUsername()
        {
            Assert.That(
            new UserSteps(Driver)
            .IncorrectLogin("123@gmail", Configurator.AppSettings.Password)
            .GetErrorLabelText(),
            Is.EqualTo("These credentials do not match our records or the user account is not allowed to log in."));
        }
    }
}
   
