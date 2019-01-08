using BoDi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;

namespace SeleniumFramework.Base
{
    [Binding]
    public sealed class SetUp
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        private IWebDriver webDriver;
        
        public IWebDriver DetermineBrowserType()
        {
            //Chrome by default
           var tagNames = ScenarioContext.Current.ScenarioInfo.Tags;
            if(tagNames.Contains("Chrome"))
            {
                    webDriver = new ChromeDriver();   
            }
            else if(tagNames.Contains("Firefox"))
            {
                    webDriver = new FirefoxDriver();
            }
            else if(tagNames.Contains("Edge"))
            {
                webDriver = new EdgeDriver();
            }
            else
            {
                throw new Exception("Browser Tag was not found");
            }
            return webDriver;
        }


        [BeforeScenario]
        public void BeforeScenario()
        {
            webDriver = DetermineBrowserType();
            ScenarioContext.Current.Add("webDriver", webDriver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            webDriver.Dispose();
        }
    }
}
