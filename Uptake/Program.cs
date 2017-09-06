using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using Uptake.Pages;
using Uptake.Test;

namespace Uptake
{
    class Program
    {
        
    
        static void Main(string[] args)
        {


            NavigationTest NT = new NavigationTest();
            NT.SetupTest();
            NT.Test();
           NT.cleanUp();

            Console.WriteLine("Done");

        }
    }
}


