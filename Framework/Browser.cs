using System.Security.Policy;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace Framework
{
    public static class Browser
    {
        public static string currentDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        //private static IWebDriver driver = new FirefoxDriver();
        private static IWebDriver driver = new ChromeDriver();
        private static string _BOUrl = "https://treasury-backoffice-e.qa.netteller.com";
        private static string _channelUrl = "https://treasury-channel-e.qa.netteller.com:8080";

        public static ISearchContext Driver
        {
            get { return driver; } 
        }

        public static string Title { get { return driver.Title; } }

        public static void Goto_BO(string url)
        {
            ExcelUtils Utils = new ExcelUtils();
            Utils.ExcelToDataTable(@"C:\Sree.xlsx");
            //Goto URL
            driver.Navigate().GoToUrl(_BOUrl + url);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(50));
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(90));
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(40));
        }
        public static void Goto_CH(string url)
        {
            ExcelUtils Utils = new ExcelUtils();
            Utils.ExcelToDataTable(@"C:\Sree.xlsx");

            driver.Navigate().GoToUrl(_channelUrl + url);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(70));
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(200));
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(120));
        }

        public static void Initialize_BO()
        {
            Goto_BO("");
        }

        public static void Initialize_CH()
        {
            Goto_CH("");
        }

        public static void Close()
        {
            driver.Close();
        }
       public static void MosueHover(IWebElement ele1, IWebElement ele2)
        {
            Actions action = new Actions(driver);
                      
           action.MoveToElement(ele1).MoveToElement(ele2).Click().Build().Perform();
            /*action.MoveToElement(ele1).Click().Build().Perform();
            Thread.Sleep(3000);
            ele2.Click();*/
            Thread.Sleep(2000);
        }

        public static bool IsElementDisplayed(IWebElement element){
            if (element.Displayed)
            {   return true;  }
            else { return false; }
        }

        public static string TodayDate()
        {
            string datestring = Browser.currentDate;
            //Console.WriteLine(datestring);
            return datestring;
        }

        public static void EnterDataOnTextbox(IWebElement ele, string Text)
        {
            //Actions action = new Actions(driver);
            //action.MoveToElement(ele).Click().Build().Perform();
            ele.Click();
            ele.Clear();
            Thread.Sleep(3000);
            ele.SendKeys(Text);
            //action.MoveToElement(ele).SendKeys(Text).Build().Perform();
        }
        
    }
}