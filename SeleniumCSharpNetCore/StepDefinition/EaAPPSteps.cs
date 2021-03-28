using NUnit.Framework;
using SeleniumCSharpNetCore.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumCSharpNetCore.StepDefinition
{   
    [Binding]
    class EaAPPSteps
    {
        private DriverHelper _driverhelper;
        HomePage home;
        LoginPage login;

        public EaAPPSteps(DriverHelper driverhelper)
        {
            _driverhelper = driverhelper;
            home = new HomePage(_driverhelper.driver);
            login = new LoginPage(_driverhelper.driver);
        }
       

        [Given(@"I have navigated to EAapp application")]
        public void GivenIHaveNavigatedToEAappApplication()
        {
            _driverhelper.driver.Url = "http://eaapp.somee.com/";
        }
        [Given(@"I click the login link")]
        public void GivenIClickTheLoginLink()
        {
            
            home.ClickLogin();
        }


        [Given(@"I have entered username and password")]
        public void GivenIHaveEnteredUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            login.EnterUsernameandPassword((string)data.UserName, (string)data.Password);
        }

        [When(@"I click Login")]
        public void WhenIClickLogin()
        {
            login.ClickLogin();
        }

        [Then(@"I should see user logged int to the application")]
        public void ThenIShouldSeeUserLoggedIntToTheApplication()
        {
            Assert.That(home.IsLogoffExist(), Is.True, "logoff is not displayed");
        }

    }
}
