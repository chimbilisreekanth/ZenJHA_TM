using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace Framework.Pages
{
    public class CH_IR{
        [FindsBy(How = How.XPath, Using = ".//*[@id='navbar-collapse-1']/ul/li[4]/a")]
        public IWebElement Tab_IR;

        [FindsBy(How = How.XPath, Using = ".//*[@id='left-fixed-panel']/div/div[2]/div/div/ul/li[1]")]
        public IWebElement IR_CDBalance;

        [FindsBy(How = How.XPath, Using = ".//*[@id='right-fluid-panel']/div/div[2]/div/div[2]/ul/li[1]")]
        public IWebElement IR_MyReports;

        [FindsBy(How = How.XPath, Using = ".//*[@id='right-fluid-panel']/div/div[2]/div/div[2]/ul/li[1]")]
        public IWebElement Header_IR;

        public void Goto_IR()
        {
            Tab_IR.Click();
            Browser.IsElementDisplayed(Header_IR);
           // LoginPage.IsTextPrence("");
        }

        public void Exe_standardReport()
        {
           // Thread.Sleep(5000);
            IR_CDBalance.Click();
            //Thread.Sleep(20000);
        }

        public void Exe_MyReport()
        {
            //Thread.Sleep(3000);
            IR_MyReports.Click();
            //Thread.Sleep(9000);
        }

        // Methods
       /* public void verifyText()
        {
            IWebElement body = IR_MyReports;
            Assert.IsTrue(body.Text.Contains("Top Questions"));
        }*/
    }
}
