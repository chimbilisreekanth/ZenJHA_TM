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
    public class CH_InternalTransfer{

             
        [FindsBy(How = How.CssSelector, Using = "span.input-group-addon")]
        public IWebElement TransferFrom;
        [FindsBy(How = How.CssSelector, Using = "td.center > button.btn.btn-primary")]
        public IWebElement TransferFrom_Select;


        [FindsBy(How = How.XPath, Using = "//form[@id='form']/div/div/div[2]/div/div/div[2]/div/span")]
        public IWebElement TransferTo;
        [FindsBy(How = How.CssSelector, Using = "th > div")]
        public IWebElement TransferTo_Sorting;
        [FindsBy(How = How.CssSelector, Using = "td.center > button.btn.btn-primary")]
        public IWebElement TransferTo_Select;


        [FindsBy(How = How.Id, Using = "ctrl-currency-1")]
        public IWebElement Amount;

        [FindsBy(How = How.Id, Using = "ctrl-input-3")]
        public IWebElement Note;

        [FindsBy(How = How.CssSelector, Using = "button.btn.btn-primary")]
        public IWebElement Button_CreateTransfer;

        public void CreateTransfer()
        {
            Thread.Sleep(10000);
            TransferFrom.Click();
            Thread.Sleep(6000);
            TransferFrom_Select.Click();
            Thread.Sleep(6000);

            TransferTo.Click();
            Thread.Sleep(6000);
            TransferTo_Sorting.Click();
            Thread.Sleep(3000);
            TransferTo_Select.Click();
            Thread.Sleep(10000);

            Browser.EnterDataOnTextbox(Amount, "1.15");
            /*Amount.Clear();
            Amount.Click();
            Amount.SendKeys("1.15");
            Thread.Sleep(10000);*/

            Note.Clear();
            Note.SendKeys("sreekanth Test");
            Button_CreateTransfer.Click();
            Console.WriteLine("reached here");
            
        }

       
    }
}
