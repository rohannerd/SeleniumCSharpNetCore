using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore
{
   public class CustomControl:DriverHelper
    {
        public static void ComboBox(string controlname, string controlvalue)
        {
            var element = driver.FindElement(By.XPath($"//input[@id='{controlname}-awed']"));         
            element.Clear();
            element.SendKeys(controlvalue);
            var autocomp = driver.FindElement(By.XPath($"//div[@id='{controlname}-dropmenu']/div[2]/ul/li[2]"));
            autocomp.Click();

        }
    }
}
