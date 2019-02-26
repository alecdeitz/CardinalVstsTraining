using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace EcdDotnetReferencePipeline.AcceptanceTests.Steps
{
    [Binding]
    public class GoogleSteps
    {
        private IWebDriver _webDriver;

        [Given(@"I go to Google")]
        public void GivenIGoToGoogle()
        {
            _webDriver = ScenarioContext.Current.Get<IWebDriver>("driver");

            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--headless");
            //_webDriver = new ChromeDriver(options);
            //_webDriver.Manage().Window.Size = new Size(1300, 1500);

            _webDriver.Navigate().GoToUrl("http://www.google.com");
        }

        [Then(@"I will see the Google Logo")]
        public void ThenIWillSeeTheGoogleLogo()
        {
            var logo = _webDriver.FindElement(By.Id("hplogo"));
            Assert.IsTrue(logo.Displayed);
            _webDriver.Quit();
        }
    }
}
