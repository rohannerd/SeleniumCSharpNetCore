using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpNetCore;

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
    }
}