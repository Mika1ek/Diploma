using Diploma.Helpers.Configuration;
using Diploma.Steps;
using Diploma.Pages;
using Allure.NUnit.Attributes;
using Allure.Net.Commons;

namespace Diploma.Tests.UITests
{
    public class DeleteProjectTest : BaseUITest
    {
        [Test(Description = "Test for deleting a project")]
        [AllureFeature("Positive")]
        [AllureSeverity(SeverityLevel.normal)]
        public void TestDeleteProject()
        {
            UserSteps userSteps = new UserSteps(Driver);
            ProjectsPage projectsPage = userSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
            ProjectSteps projectSteps = new ProjectSteps(Driver);
            projectsPage = projectSteps.AddProject("Delete");
            projectsPage = projectSteps.DeleteProject(true);

            Assert.Multiple(() =>
            {
                Assert.That(projectsPage.IsPageOpened());
                Assert.That(projectsPage.IsNameProjectAbsent("Delete"));
            });
        }
    }
}