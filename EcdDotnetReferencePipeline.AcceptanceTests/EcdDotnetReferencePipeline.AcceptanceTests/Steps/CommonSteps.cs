using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace EcdDotnetReferencePipeline.AcceptanceTests.Steps
{
    [Binding]
    public class CommonSteps
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            var driver = new ChromeDriver("C:\\Drivers\\");
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
