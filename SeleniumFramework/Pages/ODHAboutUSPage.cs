using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Remote;


namespace SeleniumFramework.Pages
{
    public class ODHAboutUSPage : BasePage
    {
        private readonly string currentUrl;
        RemoteWebDriver _webDriver;

        public ODHAboutUSPage()
        {
            _webDriver = base.webDriver;
            currentUrl = base.baseUrl + "/about-us";
        }
        #region Element Selectors
        public IWebElement executiveBiosLink => _webDriver.FindElementByXPath("//a[contains(text(), 'Executive Bios')]");
        #endregion

    }
}