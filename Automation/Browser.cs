using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sukhi_1
{
    class Browser
    {
        public static void BrowserOpen()
        {
            IWebDriver driver = new ChromeDriver();
            String url = "https://www.google.com/";
            String ID = "S3BnEe";
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(2000);
            IWebElement element = driver.FindElement(By.Id(ID));
            if (element.Displayed)
            {
                Console.WriteLine("\tBrowser element was Visible.");
            }
            else
            {
                Console.WriteLine("\tBrwoser element was not visible");
            }
            driver.Quit();
            ChromeDriver driver1 = new ChromeDriver();
            driver1.Url = url;                 //Open the provided URL in browser window
            Console.WriteLine("\tBrowser window title is: " + driver1.Title);//fetch title of the browser window and display on output console window
            Debug.WriteLine("\tBrowser window title is: " + driver1.Title);    //display title of the browser window on output/debug console (output explorer) 
            driver1.Quit();
        }
    }
}

