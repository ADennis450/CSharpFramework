using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using System.Reflection;

namespace SeleniumFramework.Pages
{
    public class ODHHomePage : BasePage
    {
        private readonly IWebDriver page;

        #region Selectors
        By aboutUSNavLink = By.XPath("//a[contains(text(), 'Who We Are')]");
        #endregion

        #region Selector Methods
        public ODHHomePage()
        {
            page = base.webDriver;
        } 

        public void GoToWelcomePage()
        {
            page.FindElement(aboutUSNavLink).Click();
        }
        #endregion





    }
}
