using OpenQA.Selenium;

namespace BasePage
{
    public class Base
    {
        protected static IWebDriver driver;

        public Base(IWebDriver webDriver)
        {
            driver = webDriver;
        }
    }
}