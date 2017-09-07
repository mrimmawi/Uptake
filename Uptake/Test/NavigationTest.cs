using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Uptake.Pages;
using Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Uptake.Test
{
    
    class NavigationTest
    {

        public IWebDriver _driver { get; set; }
        public WebDriverWait _wait { get; set; }
        MainPage mainPage;
        About about;
        Products products;

        public void SetupTest()
        {
        

            this._driver = new FirefoxDriver();
            this._wait = new WebDriverWait(this._driver, TimeSpan.FromSeconds(30));
            _driver.Navigate().GoToUrl("http://www.uptake.com");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Console.WriteLine("Step 1: Uptake.com home page opened successfully");

            mainPage = new MainPage(_driver);
            about = new About(_driver);
            products = new Products(_driver);
        }


        public void cleanUp()
        {
            this._driver.Manage().Cookies.DeleteAllCookies();
            //this._driver.Quit();
        }


        public void Test()
        {
            int i = 1;
            try
            {
                about.goToPage();
                Assert.AreEqual("About", about.getTitle().ToString());
                Console.WriteLine("Step " + ++i + ": About Page opened successfully");
                products.goToPage();
                Assert.AreEqual("Products", products.getTitle().ToString());
                Console.WriteLine("Step " + ++i + ": Products Page opened successfully");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Step " + ++i + ": " + ex.Message);
            }
            
        }

    }
}
