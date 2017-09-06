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
    class Products : Page
    {
        

        public Products(IWebDriver driver) : base(driver)
        {

         /*   if (driver.Title != "Products")
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
