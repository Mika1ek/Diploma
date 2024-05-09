using Diploma.Helpers.Configuration;
using OpenQA.Selenium;
using Diploma.Pages;
using Diploma.Steps;
using Allure.Net.Commons;
using Allure.NUnit.Attributes;

namespace Diploma.Tests.UITests
{
    public class BoundaryValuesTest : BaseUITest
    {
        [Test(Description = "Проверка на граничные значения")]      
        [AllureSeverity(SeverityLevel.normal)]
        public void ExceedingPermissibleValuesTest()
        {
            UserSteps userSteps = new UserSteps(Driver);
            ProjectsPage projectsPage = userSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
            projectsPage.ClickAddToProject();
            projectsPage.AddRandomLetters();
            string summaryValue = Driver.FindElement(By.CssSelector("[data-target=\"note behavior--maxlength-counter.control\"]")).GetAttribute("value");
            int summaryLength = summaryValue.Length;

            Assert.That(summaryLength, Is.EqualTo(80));
        }
    }
}