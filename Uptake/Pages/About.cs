using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using Uptake.Controls;

namespace Uptake.Pages
{
    class About : Page
    {

        
        [FindsBy(How = How.XPath, Using = "//*[@id='about']/div[2]/div/div/div[3]/a[1]")]
        private IWebElement _Productivity;


        public About(IWebDriver driver) : base(driver)
        {

          /*  if (driver.Title != "About")
            {
                Console.WriteLine("Wrong Page the Page is:" + driver.Title);
            }
            else
            {
                Console.WriteLine("About Page opened succesufully");
            }
            */
            PageFactory.InitElements(driver, this);

        }

        public void goToProductivity()
        {
            _Productivity.Click();
        }

    }
}
