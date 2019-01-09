using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TechTalk.SpecFlow;


namespace SeleniumFramework.Pages
{
    public class ODHAboutUSPage : BasePage
    {
        private readonly IWebDriver webDriver;

        public ODHAboutUSPage()
        {
            webDriver = base.webDriver;
            webDriver.Url = base.baseUrl + "/about-us";
        }


    }
}
