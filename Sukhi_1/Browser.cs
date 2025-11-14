using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


    class Browser
    {
         static IWebDriver driver;

        public static void BrowserOpen()
        {
            String url = "https://www.gmail.com/";
        String browser;
        Console.WriteLine( "\tEnter browser name (Chrome/Edge/Firefox): ");
        browser = Console.ReadLine();
        if(browser != null ) {
            switch (browser.ToLower())
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;
                case "edge":
                    driver = new EdgeDriver();
                    break;
                case "firefox":
                    driver = new FirefoxDriver();
                    break;
                default:
                    Console.WriteLine("\tUnsupported browser. Defaulting to Chrome.");
                    driver = new ChromeDriver();
                    break;
            }
        }
        else
        {
            Console.WriteLine("\tNo browser name provided. Defaulting to Chrome.");
            driver = new ChromeDriver();
        }
            driver.Navigate().GoToUrl(url);
        driver.Manage().Window.Maximize();              //Maximize the browser window, object of IWebDriver interface> method> Interface> method
        Thread.Sleep(4000);
        driver.Quit();
    }

    /*IWebDriver driver = new ChromeDriver();
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
    driver1.Quit();*/
}
    

