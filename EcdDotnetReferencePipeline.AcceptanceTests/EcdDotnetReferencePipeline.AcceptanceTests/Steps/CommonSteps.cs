using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using TechTalk.SpecFlow;

namespace EcdDotnetReferencePipeline.AcceptanceTests.Steps
{
    [Binding]
    public class CommonSteps
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            var driver = new InternetExplorerDriver();
            driver.Manage().Window.Maximize();
            ScenarioContext.Current.Add("driver", driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>("driver");
            driver.Quit();
        }
    }
}
