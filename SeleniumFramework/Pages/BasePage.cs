using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace SeleniumFramework.Pages
{
    public class BasePage
    {
       public IWebDriver webDriver;
        public string baseUrl; 

        public BasePage()
        {
            webDriver = (IWebDriver)ScenarioContext.Current["webDriver"];
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public string GetElementText(By element)
        {
            string title = webDriver.FindElement(element).Text;
            return title;
        }
            
        public void Navigate(string url)
        {
            webDriver.Navigate().GoToUrl(url);
            baseUrl = url;
        }

        public void ClickOn(By locator)
        {
            webDriver.FindElement(locator).Click();
        }

        public string GetTitle()
        {
           string title = webDriver.Title;
            return title;
        }

        public void CompareElementToString(By element, string text)
        {
           string elementText = GetElementText(element);
            Assert.AreEqual(elementText, text);
        }

        public void ComparePageTitleToString(string title, string text)
        {
            Assert.AreEqual(title, text);
        }

    }
}
