using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumFramework.Pages;

namespace SeleniumFramework.StepDefinitions
{
    [Binding]
    public class SogetiHomeSteps
    {

        SogetiHomePage homePage = new SogetiHomePage();

        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            homePage.Navigate(url);
        }

        [Given(@"I click on the ""(.*)"" link")]
        public void GivenIClickOnTheLink(string p0)
        {
            homePage.aboutUs.Click();
            System.Threading.Thread.Sleep(4000);
        }
    }
}
