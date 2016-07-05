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
    public class CH_DashBoard{
        [FindsBy(How = How.XPath, Using = ".//*[@id='navbar-collapse-1']/ul/li[2]/a")]
        public IWebElement Tab_Accounts;

        [FindsBy(How = How.XPath, Using = ".//*[@id='navbar-collapse-1']/ul/li[2]/ul/li[2]/a")]
        public IWebElement ResearchTrans;

        [FindsBy(How = How.XPath, Using = "//a[@data-ui-sref-active-if='payables']")]
        public IWebElement Tab_Payables;

        [FindsBy(How = How.XPath, Using = "//a[text()='Transfer']")]
        public IWebElement Subtab_Transfer;
        // .//*[@id='navbar-collapse-1']/ul/li[3]/ul/li[1]/a
        //[FindsBy(How = How.LinkText, Using = "Create Transfer")]
        [FindsBy(How = How.XPath, Using = "//*[@class='ng-binding ng-scope ng-isolate-scope'][text()='Create Transfer']")]
        //[FindsBy(How = How.XPath, Using = "//li/ul/li[3]/a")]
        public IWebElement CreateTransfer;

        [FindsBy(How = How.XPath, Using = ".//*[@id='navbar-collapse-1']/ul/li[2]/ul/li[2]/a")]
        public IWebElement Tab_researchTrans;

        [FindsBy(How = How.XPath, Using = ".//*[@id='form']/div/div[1]/div/div[1]/h3")]
        public IWebElement Header_ResearchTransaction;
        

        public void Goto_RT()
        {
            Browser.IsElementDisplayed(Header_ResearchTransaction);
           // Thread.Sleep(15000);
           // IsTextPrence();
            Tab_Accounts.Click();
           // Thread.Sleep(1000);
            ResearchTrans.Click();
            Browser.IsElementDisplayed(Header_ResearchTransaction);
           // Thread.Sleep(2000);
        }

        public void Goto_Transfers()
        {
            Thread.Sleep(20000);
            Tab_Payables.Click();
            Thread.Sleep(2000);         
            Browser.MosueHover(Subtab_Transfer, CreateTransfer);
           // CreateTransfer.Clear();
            //Thread.Sleep(2000);
        }
    }
}
