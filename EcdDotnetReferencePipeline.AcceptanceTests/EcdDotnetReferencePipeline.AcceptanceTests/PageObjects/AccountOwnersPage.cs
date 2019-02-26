using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace EcdDotnetReferencePipeline.AcceptanceTests.PageObjects
{
    public class AccountOwnersPage
    {
        private List<IWebElement> _accountOwners;

        public AccountOwnersPage(IWebDriver driver)
        {
            _accountOwners = driver.FindElements(By.CssSelector("h2")).ToList();
        }

        public static AccountOwnersPage NavigateTo(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(ConfigurationSettings.BaseUrl);
            return new AccountOwnersPage(driver);
        }

        public List<string> AccountOwnerNames { get { return _accountOwners.Select(m => m.Text).ToList(); } }
    }
}
