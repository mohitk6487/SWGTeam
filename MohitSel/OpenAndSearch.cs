using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace MohitSel
{
    public class OpenAndSearch
    {
        public static void OpenandSearch()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.poemfrommohit.blogspot.com/");
            //IWebElement searchBox = driver.FindElement(By.Name("q"));
            //searchBox.SendKeys("poem from mohit");
            //searchBox.Submit();
        }
    }
}
