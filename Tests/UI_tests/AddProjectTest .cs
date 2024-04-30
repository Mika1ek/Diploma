/*using OpenQA.Selenium;
using Diploma.Helpers.Configuration;
using Diploma.Elements;
using Diploma.Steps;
using Diploma.Pages;
using Allure.NUnit.Attributes;
using Allure.Net.Commons;

namespace Diploma.Tests.UI_tests
{
    [AllureEpic("Web Interface")]
    [AllureFeature("Login feature", "AddProject feature")]
    public class AddProjectTest : BaseTest
    {
        [Test(Description = "Проверка успешного создания проекта")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureStory("Story1")]
        public void TestAddProject()
        {
            UserSteps userSteps = new UserSteps(Driver);
            ProjectsPage projectsPage = userSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
            ProjectSteps projectSteps = new ProjectSteps(Driver);

            projectsPage = projectSteps.AddProject("Test_Project");

            Assert.Multiple(() =>
            {
                Assert.That(projectsPage.IsPageOpened());
                Assert.That(projectsPage.NameProject.Text.Trim(), Is.EqualTo("Test_Project"));
            });
        }
    }
}
   
*/