using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore.Pages
{
    class HomePage:DriverHelper
    {
        IWebElement _linkLogin => driver.FindElement(By.LinkText("Login"));
        IWebElement _logoff => driver.FindElement(By.LinkText("Log off"));
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
