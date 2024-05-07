using Diploma.Helpers.Configuration;
using Diploma.Steps;
using Diploma.Pages;
using Allure.NUnit.Attributes;
using Allure.Net.Commons;

namespace Diploma.Tests.UITests
{
    public class AddProjectTest : BaseUITest
    {
        [Test(Description = "Test for creating a project")]
        [AllureFeature("Positive")]
        [AllureSeverity(SeverityLevel.normal)]
        public void TestAddProject()
        {
            UserSteps userSteps = new UserSteps(Driver);
            ProjectsPage projectsPage = userSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
            ProjectSteps projectSteps = new ProjectSteps(Driver);

            projectsPage = projectSteps.AddProject("Project");

            Assert.Multiple(() =>
            {
                Assert.That(projectsPage.IsPageOpened());
                Assert.That(projectsPage.NameProject.Text.Trim(), Is.EqualTo("Project"));
            });
        }
    }
}