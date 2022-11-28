using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasePage
{
    public class Page : Base
    {
        private static WebDriverWait wait;

        public Page(IWebDriver webDriver) : base(webDriver)
        {
            wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(5));
        }
        public IWebElement btn_bank_manager_login => wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div/div/div[2]/div/div[1]/div[2]/button")));
        public IWebElement btn_customers => wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div/div/div[2]/div/div[1]/button[3]")));
        public IWebElement input_search_customer => wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/form/div/div/input")));
        private IWebElement found_element => wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div/table/tbody/tr/td[1]")));

        public void Check_that_alert_message_contains_text(string message) => Assert.That(found_element.Text.ToLower().Contains(message));
        public void Click_btn(string Button) => driver.FindElement(By.Name(Button)).Click();
        public void Click_btn_bank_manager_login() => btn_bank_manager_login.Click();
        public void Click_btn_customers() => btn_customers.Click();
        public void InputText(string text)
        {
            input_search_customer.Click();
            input_search_customer.SendKeys(text);
        }

    }
}
