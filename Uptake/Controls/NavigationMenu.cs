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

        [FindsBy(How = How.XPath, Using = "//*[@id='header']/div[1]/div[1]/a/img")]
        private IWebElement MainPage;


        public NavigationMenu(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void goToAbout(IWebDriver driver)
        {
            try
            {
                if (About != null)
                {
                    About.Click();
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("Error: [About] Link is not available on a page - " + driver.Url);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public Products goToProducts(IWebDriver driver)
        {
            try
            {
                if (Products != null)
                {
                    Products.Click();
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("Error: [About] Link is not available on a page - " + driver.Url);
                }
  
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            
            return new Products(driver);
        }

        public Products goToMainPage(IWebDriver driver)
        {
            try
            {
                if (MainPage != null)
                {
                    MainPage.Click();
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("Error: [About] Link is not available on a page - " + driver.Url);
                }

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
