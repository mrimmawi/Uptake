using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Uptake.Pages;

namespace Uptake.Controls
{
    class NavigationMenu
    {

        [FindsBy(How = How.XPath, Using = "//*[@id='header']/div[1]/nav/a[1]")]
        private IWebElement About;

        [FindsBy(How = How.XPath, Using = "//*[@id='header']/div[1]/nav/a[2]")]
        private IWebElement Products;

        [FindsBy(How = How.XPath, Using = "//*[@id='header']/div[1]/nav/a[3]")]
        private IWebElement Industries;

        [FindsBy(How = How.XPath, Using = "//*[@id='header']/div[1]/nav/a[4]")]
        private IWebElement NewsRoom;


        public About goToAbout(IWebDriver driver)
        {
            try
            {
                About.Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return new About(driver);
        }

        public Products goToProducts(IWebDriver driver)
        {
            try
            {
                Products.Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            
            return new Products(driver);
        }
    }
}
