using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumFramework.StepDefinitions;

namespace SeleniumFramework.Pages
{
    public class SogetiHomePage : BaseSteps
    {
       
       public SogetiHomePage()
        {
            PageFactory.InitElements(base.webDriver, this);
        }


        [FindsBy(How = How.CssSelector, Using = "#header > div.desktop_wrapper > nav > ul > li.has-children.level0 > div > span")]
        public IWebElement aboutUs;

    }
}
