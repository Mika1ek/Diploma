using OpenQA.Selenium;

namespace Diploma.Steps
{
    public class AllureSteps
    {
        protected IWebDriver Driver;

        public AllureSteps(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
