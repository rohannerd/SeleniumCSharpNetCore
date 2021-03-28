using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore.Pages
{
    class HomePage
    {
        private IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement _linkLogin => driver.FindElement(By.LinkText("Login"));
        IWebElement _logoff => driver.FindElement(By.XPath("//a[text()='Log off']"));
        public void ClickLogin()
        {
            _linkLogin.Click();
        }
        public bool IsLogoffExist()
        {
           return _logoff.Displayed;
        }
    }
}
