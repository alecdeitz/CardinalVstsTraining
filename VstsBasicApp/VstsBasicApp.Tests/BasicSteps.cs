using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using TechTalk.SpecFlow;

namespace VstsBasicApp.Tests
{
    [Binding]
    public class BasicSteps
    {
        private IWebDriver _webDriver;

        [Given(@"we open Google")]
        public void GivenWeOpenGoogle()
        {
            _webDriver = new InternetExplorerDriver();
            _webDriver.Manage().Window.Maximize();

            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--headless");
            //_webDriver = new ChromeDriver(options);
            //_webDriver.Manage().Window.Size = new Size(1300, 1500);

            _webDriver.Navigate().GoToUrl("http://www.google.com");
        }

        [Then(@"Google is open")]
        public void ThenGoogleIsOpen()
        {
            var logo = _webDriver.FindElement(By.Id("hplogo"));
            Assert.IsTrue(logo.Displayed);
            _webDriver.Quit();
        }
    }
}
