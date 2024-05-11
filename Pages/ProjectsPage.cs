using Allure.NUnit.Attributes;
using Diploma.Elements;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Reflection;

namespace Diploma.Pages
{
    public class ProjectsPage : PageBase
    {
        private static string END_POINT = "";

        private static By pageTitle = By.ClassName("page-title__title");
        private static By addProjectButton = By.CssSelector("[data-target='home--index.addButton']");
        private static By projectDialog = By.XPath("//*[@id='projectDialog']");
        private static By selectFileButton = By.CssSelector("[data-action='click->doSelectAvatar']");
        private static By fileInput = By.CssSelector("[data-target='fileInput']");
        private static By avatarPng = By.XPath("//img[starts-with(@src,'https://Alek.testmo.net/attachments/view/')]");
        private static By summary = By.CssSelector("[data-target=\"note behavior--maxlength-counter.control\"]");
        private static By projectName = By.CssSelector("[data-target='name']");
        private static By addDemoProject = By.CssSelector("[data-target='addDemoProject']");
        private static By submitButton = By.CssSelector("[data-target='submitButton']");
        private static By nameProject = By.XPath("//a[contains(@href, 'alek.testmo.net/projects/view') and contains(text(), 'Project')]");
        private static By admin = By.CssSelector("[data-content='Admin']");
        private static By PopupMessageBy = By.CssSelector("[class='avatar__text__identifier']");
        private static By PopupMessageDataContextBy = By.CssSelector("[data-content='Alek']");

        public ProjectsPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {

        }

        public IWebElement PageTitle => WaitsHelper.WaitForExists(pageTitle);

        public Button AddProjectButton => new Button(Driver, addProjectButton);


        public IWebElement ProjectDialog => WaitsHelper.WaitForExists(projectDialog);

        public IWebElement SelectFileButton => WaitsHelper.WaitForExists(selectFileButton);

        public IWebElement FileInput => WaitsHelper.WaitForExists(fileInput);

        public IWebElement avatarpng => WaitsHelper.WaitForExists(avatarPng);

        public IWebElement Summary => WaitsHelper.WaitForExists(summary);

        public IWebElement ProjectName => WaitsHelper.WaitForExists(projectName);

        public Checkbox AddDemoProject => new Checkbox(Driver, addDemoProject);

        public Button SubmitButton => new Button(Driver, submitButton);

        public IWebElement NameProject => WaitsHelper.WaitForExists(nameProject);

        public Button Admin => new Button(Driver, admin);

        public IWebElement PopupMessage => WaitsHelper.WaitForExists(PopupMessageBy);
        public IWebElement PopupMessageDataContext => WaitsHelper.WaitForExists(PopupMessageDataContextBy);

        [AllureStep("Нажата кнопка добавления проекта")]
        public void ClickAddToProject() => AddProjectButton.Click();

        [AllureStep("Нажата кнопка подтверждения")]
        public ProjectsPage ClickSubmitButton()
        {
            SubmitButton.Click();
            Thread.Sleep(3000);
            return new ProjectsPage(Driver, true);
        }

        [AllureStep("Нажата кнопка Admin")]
        public AdminPage ClickAdmin()
        {
            Admin.Click();
            return new AdminPage(Driver, true);
        }
    
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

        [AllureStep("Отобразилось всплывающее сообщение")]
        public void MoveToPopupMessage()
        {
            var allPopupMessage = WaitsHelper.WaitForAllVisibleElementsLocatedBy(PopupMessageBy); // вернёт коллекцию всех найденых на странице всплывающих сообщений
            var actions = new Actions(Driver);

            foreach (var msg in allPopupMessage) //перебор всех всплывающих сообщений
            {
                actions
                    .MoveToElement(msg)
                    .Build()
                    .Perform();
            }
        }

        public bool IsPopupVisible()
        {
            return PopupMessageDataContext.Displayed;
        }

        public bool IsTooltipTextCorrect(string tooltipText, string expectedText)
        {
            if (tooltipText == expectedText)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Tooltip text is incorrect. Expected: " + expectedText + ", actual: " + tooltipText);
                return false;
            }
        }

        [AllureStep("Отобразилось диалоговое окно")]
        public bool DialogWindowOpened()
        {
            return ProjectDialog.Displayed;
        }

        [AllureStep("Нажата кнопка добавления файла")]
        public void ClickAddFile()
        {
            SelectFileButton.Click();
            string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string filePath = Path.Combine(assemblyPath, "Resource", "avatar.png");
            FileInput.SendKeys(filePath);
        }

        [AllureStep("Отображение аватара")]
        public bool AvatarUpload()
        {
            return avatarpng.Displayed;
        }

        public string GenerateRandomLetters(int length)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public void AddRandomLetters()
        {
            string randomLetters = GenerateRandomLetters(81);
            Summary.SendKeys(randomLetters);
        }

        public bool IsNameProjectAbsent(string text)
        {
            return !IsElementPresent(By.XPath($"//div[contains(text(), '{text}')]"));
        }

        public bool IsElementPresent(By locator)
        {
            try
            {
                Driver.FindElement(locator);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
