using Diploma.Helpers.Configuration;
using Diploma.Steps;
using Diploma.Pages;
using Allure.NUnit.Attributes;
using Allure.Net.Commons;

namespace Diploma.Tests.UI_tests
{
    [AllureEpic("Web Interface")]
    [AllureFeature("Login feature", "AddProject feature", "DeleteProject")]

    public class DeleteProjectTest : BaseTest
    {
        [Test(Description = "Проверка успешного удаления созданного проекта")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureStory("Story2")]
        public void TestDeleteProject()
        {
            UserSteps userSteps = new UserSteps(Driver);
            ProjectsPage projectsPage = userSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
            ProjectSteps projectSteps = new ProjectSteps(Driver);
            projectsPage = projectSteps.AddProject("Test_Delete");
            projectsPage = projectSteps.DeleteProject(true);

            Assert.Multiple(() =>
            {
                Assert.That(projectsPage.IsPageOpened());
                Assert.That(projectsPage.IsNameProjectAbsent("Test_Delete"));
            });
        }
    }
}
   
