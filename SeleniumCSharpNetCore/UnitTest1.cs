using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpNetCore;
using SeleniumCSharpNetCore.Pages;

namespace Tests
{
    public class Tests:DriverHelper
    {
        
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver("C:\\Users\\Mushtaq\\Desktop\\Selenium Hybrid Framework");
        }

        [Test]
        public void Test1()
        {
            driver.Url = "https://demowf.aspnetawesome.com/";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");

           // CustomControl control = new CustomControl();
              CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo","Almond");
            Assert.Pass();
        }
        [Test]
        public void LoginTest()
        {
            driver.Url = "http://eaapp.somee.com/";
            HomePage home = new HomePage();
            LoginPage login = new LoginPage();
            home.ClickLogin();
            login.EnterUsernameandPassword("admin","password");
            login.ClickLogin();
            Assert.That(home.IsLogoffExist(),Is.True,"logoff is not displayed");
        }
    }
}