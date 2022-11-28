using BasePage;
using System;
using TechTalk.SpecFlow;

namespace Lab_2.StepDefinitions
{
    [Binding]
    public class SearchCustomerStepDefinitions : BaseSteps
    {
        private Page page;

        [Given(@"the user is on the main page")]
        public void GivenTheUserIsOnTheHomepage()
        {
            driver.Url = "https://www.globalsqa.com/angularJs-protractor/BankingProject/#/login";
            page = new Page(driver);
        }

        [When(@"the user clicks on the Bank Manager Login")]
        public void WhenTheUserClicksOnTheBankManagerLogin()
        {
            page.Click_btn_bank_manager_login();
        }

        [When(@"the user clicks on Customers")]
        public void WhenTheUserClicksOn()
        {
            page.Click_btn_customers();
        }


        [When(@"the user enters the customer")]
        public void WhenTheUserEntersTheCustomer()
        {
            page.InputText("Ron");
        }

        [Then(@"the result Customer should display")]
        public void ThenTheResultCustomerShouldDisplay()
        {
            page.Check_that_alert_message_contains_text("ron");
        }
    }
}
