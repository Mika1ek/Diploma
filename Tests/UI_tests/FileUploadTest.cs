using Diploma.Helpers.Configuration;
using Diploma.Pages;
using Diploma.Steps;
using Allure.NUnit.Attributes;
using Allure.Net.Commons;

namespace Diploma.Tests.UI_tests
{
    [TestFixture]
    [AllureEpic("Web Interface")]
    [AllureFeature("Login feature", "AddProject feature")]
    public class FileUploadTest : BaseTest
    {
        [Test(Description = "Проверка на загрузку файла")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureStory("Story5")]
        public void TestFileUpload()
        {
            UserSteps userSteps = new UserSteps(Driver);
            ProjectsPage projectsPage = userSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
            projectsPage.ClickAddToProject();
            projectsPage.ClickAddFile();
            
            Assert.That(projectsPage.AvatarUpload);
        }
    }
}
   
