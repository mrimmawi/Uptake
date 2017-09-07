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
            PageFactory.InitElements(driver, this);
        }

        public override void goToPage()
        {
            _menu.goToProducts(driver);
        }

    }
}
