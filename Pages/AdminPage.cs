using Diploma.Elements;
using OpenQA.Selenium;
using NUnit.Allure.Attributes;


namespace Diploma.Pages
{
    public class AdminPage : PageBase
    {
        private static string END_POINT = "admin/projects";

        private static readonly By pageTitleBy = By.XPath("//h1[@class='page-title']");
        private static readonly By DeleteButtonBy = By.CssSelector("[data-action='delete']");
        private static readonly By deleteProjectDialogBy = By.Id("delete-project-dialog");
        private static readonly By CheckboxDeleteBy = By.CssSelector("[data-target='confirmationLabel']");
        private static readonly By DeleteProjectButtonBy = By.CssSelector("[data-target='deleteButton']");

        public AdminPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {

        }

        public IWebElement PageTitle => WaitsHelper.WaitForExists(pageTitleBy);

        public IWebElement DeleteButton => WaitsHelper.WaitForExists(DeleteButtonBy);

        public IWebElement DeleteProjectDialog => WaitsHelper.WaitForExists(deleteProjectDialogBy);

        public IWebElement CheckboxDelete => WaitsHelper.WaitForExists(CheckboxDeleteBy);

        public IWebElement DeleteProjectButton => WaitsHelper.WaitForExists(DeleteProjectButtonBy);

        [AllureStep("Нажата кнопка корзины")]
        public void ClickDeleteButton() => DeleteButton.Click();

        [AllureStep("Выбран чек-бокс")]
        public void SetCheckbox(bool flag) => CheckboxDelete.Click();

        [AllureStep("Нажата кнопка удаления проекта")]
        public void ClickDeleteProject() => DeleteProjectButton.Click();

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public override bool IsPageOpened()
        {
            try
            {
                return PageTitle.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
