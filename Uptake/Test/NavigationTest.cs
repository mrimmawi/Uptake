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
        

        public void SetupTest()
        {
            this._driver = new FirefoxDriver();
            this._wait = new WebDriverWait(this._driver, TimeSpan.FromSeconds(30));
            _driver.Navigate().GoToUrl("http://www.uptake.com");

        }


        public void cleanUp()
        {
            this._driver.Manage().Cookies.DeleteAllCookies();
            this._driver.Quit();
        }


        public void Test()
        {
            try
            {
                MainPage mainPage = new MainPage(_driver);
                About about = mainPage.goToAbout(_driver);
                Assert.AreEqual(about.getTitle().ToString(), "About");
                Console.WriteLine("About Page opened successfully");
                Products products = about.goToProducts(_driver);
                Assert.AreEqual(products.getTitle().ToString(), "Products");
                Console.WriteLine("Products Page opened successfully");
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

    }
}
