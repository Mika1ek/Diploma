/*using Diploma.Pages;
using Diploma.Helpers.Configuration;
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
            LoginPage loginPage = userSteps.IncorrectLogin("123@gmail.com", Configurator.AppSettings.Password);
            ProjectsPage projectsPage = new(Driver);

            try
            {
                Assert.That(loginPage.IsPageOpened);
            }
            catch (Exception ex) { Logger.Error(ex, "Логируем ошибку"); }
        }

        [Test(Description = "Тест имитирует дефект и должен упасть")]
        public void FailedLoginTest()
        {
            UserSteps userSteps = new UserSteps(Driver);
            LoginPage loginPage = userSteps.IncorrectLogin("123@gmail.com", Configurator.AppSettings.Password);
            ProjectsPage projectsPage = new ProjectsPage(Driver);

            //Thread.Sleep(25000);
            Assert.That(projectsPage.IsPageOpened);
        }
    }
}*/