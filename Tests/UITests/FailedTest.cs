<<<<<<< HEAD
﻿using Diploma.Pages;
using Diploma.Helpers.Configuration;
=======
﻿/*using Diploma.Helpers.Configuration;
>>>>>>> 6e2de829f21eda351d41e7431fe996f12ed481d1
using Diploma.Pages;
using Diploma.Steps;
using Allure.NUnit.Attributes;
using Allure.Net.Commons;

namespace Diploma.Tests.UITests
{
<<<<<<< HEAD
    public class FailedTest : BaseUITest
=======
    public class FailedTest: BaseUITest
>>>>>>> 6e2de829f21eda351d41e7431fe996f12ed481d1
    {
        public void FailedLoginTestNlog()
        {
            UserSteps userSteps = new UserSteps(Driver);
<<<<<<< HEAD
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
            Thread.Sleep(5000);
            Assert.That(projectsPage.IsPageOpened);
        }
    }
}
=======
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
>>>>>>> 6e2de829f21eda351d41e7431fe996f12ed481d1
