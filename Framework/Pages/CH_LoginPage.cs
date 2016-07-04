using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public class CH_LoginPage{

        

        [FindsBy(How = How.XPath, Using = ".//*[@id='login-view']/div/div[1]/h3")]
        public IWebElement Header_Login;

        [FindsBy(How = How.XPath, Using = ".//*[@id='inputCompanyId']")]
        public IWebElement CompanyId;

        [FindsBy(How = How.XPath, Using = ".//*[@id='inputID']")]
        public IWebElement inputID;

        [FindsBy(How = How.XPath, Using = ".//*[@id='inputPassword']")]
        public IWebElement Password;

        [FindsBy(How = How.XPath, Using = ".//*[@id='login-view']/div/div[2]/button")]
        public IWebElement LoginID_button;


        public void Goto()
        {
            Browser.Goto_CH("/#/login");
            //Thread.Sleep(1000);
        }


        public void CH_Login()
        {
           // Thread.Sleep(2000);
           Browser.IsElementDisplayed(Header_Login);

            CompanyId.SendKeys("Disney");
            inputID.SendKeys("WaltWhite");
            Password.SendKeys("password1");
            LoginID_button.Click();

           
        }
    }
}
