/*using Diploma.Helpers.Configuration;
using Diploma.Pages;
using Diploma.Steps;
using Allure.NUnit.Attributes;
using Allure.Net.Commons;

namespace Diploma.Tests.UITests
{
    public class FailedTest: BaseUITest
    {
        public void FailedLoginTestNlog()
        {
            UserSteps userSteps = new UserSteps(Driver);
            ProjectsPage loginPage = userSteps.IncorrectLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);           

            try
            {
                Assert.That(projectsPage.IsPageOpened);
            }
            catch (Exception ex) { Logger.Error(ex, "Логируем ошибку"); }
        }
    }
        [Test(Description="Тест имитирует дефект и должен упасть")]
        public void FailedLogin_Test()
        {
            UserSteps userSteps = new UserSteps (Driver);
            LoginPage loginPage = userSteps.IncorrectLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
            ProjectsPage projectsPage = new ProjectsPage (Driver);
            Assert.That(projectsPage.IsPageOpened);
        }
}*/