using System;
using TechTalk.SpecFlow;
using SeleniumFramework.Pages;
using NUnit;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumFramework.StepDefinitions
{
    [Binding]
    public class ODHSteps
    {
        ODHHomePage homePage = new ODHHomePage();
        ODHAboutUSPage aboutPage = new ODHAboutUSPage();

        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            homePage.Navigate(url);
        }



        [Then(@"I should see the text ""(.*)""")]
        public void ThenIShouldSeeTheText(string text)
        {
           
            
        }

        [When(@"I go to the About Us Welcome Page")]
        public void WhenIGoToTheAboutUsWelcomePage()
        {
           string title = homePage.GetTitle();
            homePage.aboutUSNavLink.Click();
        }

        [When(@"I go to the ExectutiveBios link")]
        public void WhenIGoToTheExectutiveBiosLink()
        {
            aboutPage.executiveBiosLink.Click();
        }

    }
}
