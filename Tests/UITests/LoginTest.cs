using Diploma.Helpers.Configuration;
using Diploma.Pages;
using Diploma.Steps;
using Allure.NUnit.Attributes;
using Allure.Net.Commons;

namespace Diploma.Tests.UITests
{
    public class LoginTest : BaseUITest
    {
        [Test(Description = "Positive test login standart user")]
        [AllureFeature("Positive")]
        [AllureSeverity(SeverityLevel.critical)]
        
        public void SuccessfulLogin()
        {
            UserSteps userSteps = new UserSteps(Driver);
            ProjectsPage projectsPage = userSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

            Assert.That(projectsPage.IsPageOpened);
        }

        [Test(Description = "Negative test login unknown user")]
        [AllureFeature("Negative")]
        [AllureSeverity(SeverityLevel.blocker)]
       
        public void InvalidLogin()
        {
            Assert.That(
            new UserSteps(Driver)
            .IncorrectLogin("123@gmail.com", Configurator.AppSettings.Password)
            .GetErrorLabelText(),
            Is.EqualTo("These credentials do not match our records or the user account is not allowed to log in."));
        }
    }
}
 