using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SeleniumFramework.StepDefinitions
{
    public class BaseSteps
    {
        public IWebDriver webDriver;

        public BaseSteps()
        {
            webDriver = (IWebDriver)ScenarioContext.Current["webDriver"];
        }

        public void Navigate(string url)
        {
            webDriver.Navigate().GoToUrl(url);   
        }
    }
}
