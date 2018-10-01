﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
            _webDriver = new ChromeDriver();
            _webDriver.Manage().Window.Maximize();
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