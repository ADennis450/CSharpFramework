using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace SeleniumFramework.Pages
{
    public class ODHHomePage : BasePage
    {
        RemoteWebDriver _webDriver;

        #region Constructor
        public ODHHomePage()
        {
            _webDriver = base.webDriver;

        }
        #endregion
        #region Selectors
        public IWebElement aboutUSNavLink => _webDriver.FindElementByXPath("//a[contains(text(), 'Who We Are')]");
        public IWebElement knowOurProgramsNavLink => _webDriver.FindElementByXPath("//a[contains(text(), 'Know our')]");
        #endregion       
    }
}
