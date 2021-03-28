using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumCSharpNetCore.Hooks
{
    [Binding]
    public  class Hooks1
    {
        private DriverHelper _driverhelper;

        public Hooks1(DriverHelper driverhelper)
        {
            _driverhelper = driverhelper;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {

            
            ChromeOptions option = new ChromeOptions();
            option.AddArguments("start-maximized");
            option.AddArguments("--disable-gpu");
           // option.AddArguments("--headless");

            new DriverManager().SetUpDriver(new ChromeConfig());
            _driverhelper.driver = new ChromeDriver(option);
            
        }
    

        [AfterScenario]
        public void AfterScenario()
        {
            _driverhelper.driver.Quit();
        }
    }
}
