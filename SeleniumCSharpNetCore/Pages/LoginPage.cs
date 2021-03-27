using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore.Pages
{
    class LoginPage:DriverHelper
    {
        IWebElement _username => driver.FindElement(By.Name("UserName"));
        IWebElement _password => driver.FindElement(By.Name("Password"));
        IWebElement _loginbtn => driver.FindElement(By.XPath("//div/input[@value='Log in']"));

        public void EnterUsernameandPassword(string username, string password)
        {
            _username.SendKeys(username);
            _password.SendKeys(password);
        }
        public void ClickLogin()
        {
            _loginbtn.Click();
        }
    }
}
