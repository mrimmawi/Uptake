using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using Uptake.Pages;
using Uptake.Controls;

namespace Uptake
{
    class MainPage : Page
    {


        public MainPage(IWebDriver driver) : base(driver)
        {

/*            if (driver.Title != "Analytics for the industrial internet")
            {
                Console.WriteLine("Wrong Page");
            }
            else
            {
                Console.WriteLine("good Page");
            }
  */          

    
        }

    }
}
