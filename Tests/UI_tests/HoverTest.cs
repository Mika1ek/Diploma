using Diploma.Helpers.Configuration;
using OpenQA.Selenium;
using Diploma.Pages;
using Diploma.Steps;
using Allure.Net.Commons;
using Allure.NUnit.Attributes;

namespace Diploma.Tests.UI_tests
{
 /*   [TestFixture]
    [AllureEpic("Web Interface")]
    [AllureFeature("Login feature")]

    public class HoverTest : BaseTest
    {
        [Test(Description = "Проверка на скриншот")]
        [AllureSeverity(SeverityLevel.blocker)]
        [AllureIssue("TMS-123")]
        [AllureTms("Req-456")]
        [AllureLink("github", "https://github.com/mspokrovsk/Diplom_Pokrovskaya/blob/develop/Tests/UI_tests/HoverTest.cs")]
        [AllureStory("Story3")]
        public void HoverTests()
        {
            UserSteps userSteps = new UserSteps(Driver);
            ProjectsPage projectsPage = userSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
            projectsPage.HoverOverHoverElement();
            string tooltipText = Driver.FindElement(By.CssSelector("[data-content='mspokrovsk']")).Text;

            Assert.That(projectsPage.IsTooltipTextCorrect(tooltipText, "mspokrovsk"));
        }
    }*/
}
   
