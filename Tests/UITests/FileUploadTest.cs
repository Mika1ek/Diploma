using Diploma.Helpers.Configuration;
using Diploma.Pages;
using Diploma.Steps;
using Allure.NUnit.Attributes;
using Allure.Net.Commons;

namespace Diploma.Tests.UITests
{
    public class FileUploadTest : BaseUITest
    {
        [Test(Description = "File upload test")]
        [Category("Positive")]
        [AllureSeverity(SeverityLevel.normal)]
        public void TestFileUpload()
        {
            UserSteps userSteps = new UserSteps(Driver);
            ProjectsPage projectsPage = userSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
            projectsPage.ClickAddToProject();
            projectsPage.ClickAddFile();
            Thread.Sleep(3000);

            Assert.That(projectsPage.AvatarUpload);
        }
    }
}