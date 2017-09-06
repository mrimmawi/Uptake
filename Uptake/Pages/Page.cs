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

    class Page : NavigationMenu
    {
        protected IWebDriver driver;
        
        public Page(IWebDriver driver)
        { 
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public String getTitle()
        {
            return driver.Title;
        }

    }
}
