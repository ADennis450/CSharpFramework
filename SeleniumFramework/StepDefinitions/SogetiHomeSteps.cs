using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CSharpFramework.StepDefinitions
{
    [Binding]
    public class SogetiHomeSteps
    {
        private readonly IWebDriver webDriver;
        
        public SogetiHomeSteps(IWebDriver webdriver)
        {
            webDriver = webdriver;
        }

        [Given(@"I am on the Sogeti home page")]
        public void GivenIAmOnTheSogetiHomePage()
        {
            webDriver.Navigate().GoToUrl("https://sogeti.com");
            System.Threading.Thread.Sleep(5000);
        }
        
        [Given(@"I click on the ""(.*)"" link")]
        public void GivenIClickOnTheLink(string p0)
        {
            webDriver.FindElement(By.LinkText("About us")).Click();
        }
    }
}
