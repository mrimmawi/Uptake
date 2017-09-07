using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Uptake.Controls;

namespace Uptake
{

    abstract class Page 
    {
        protected IWebDriver driver;
        protected NavigationMenu _menu;

        abstract public void goToPage();

        public Page(IWebDriver driver)
        { 
            this.driver = driver;
            this.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _menu = new NavigationMenu(driver);
            PageFactory.InitElements(driver, this);
        }

        public String getTitle()
        {
            return driver.Title;
        }

        


    }
}
