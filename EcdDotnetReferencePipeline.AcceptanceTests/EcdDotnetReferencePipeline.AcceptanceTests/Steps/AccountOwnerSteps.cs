using EcdDotnetReferencePipeline.AcceptanceTests.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace EcdDotnetReferencePipeline.AcceptanceTests.Steps
{
    [Binding]
    public class AccountOwnerSteps
    {
        private IWebDriver _webDriver;
        private AccountOwnersPage _accountOwnersPage;

        [Given(@"I am on the Account Owners page")]
        public void GivenIAmOnTheAccountOwnersPage()
        {
            _webDriver = ScenarioContext.Current.Get<IWebDriver>("driver");

            _accountOwnersPage = AccountOwnersPage.NavigateTo(_webDriver);
        }

        [Then(@"I see a list of account owners")]
        public void ThenISeeAListOfAccountOwners()
        {
            Assert.IsTrue(_accountOwnersPage.AccountOwnerNames.Contains("Account Owner: Bucky Barnes"));
        }
    }
}
