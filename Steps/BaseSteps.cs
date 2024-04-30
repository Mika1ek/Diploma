using OpenQA.Selenium;

namespace Diploma.Steps
{
    public class BaseSteps
    {
        protected IWebDriver Driver;

        public BaseSteps(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
