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
           homePage.GoToWelcomePage();
        }


    }
}
