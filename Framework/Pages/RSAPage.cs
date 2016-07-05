using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Framework.BO_Pages
{
    public class RSAPage
    {
        //RSA -- Sreekanth
        [FindsBy(How = How.XPath, Using = "html/body/div[5]/div/div/div/div[3]/button")]
        public IWebElement oopsError1;
        [FindsBy(How = How.XPath, Using = "html/body/div[4]/div/div/div/div[3]/button")]
        public IWebElement oopsError2;

        [FindsBy(How = How.XPath, Using = ".//*[@id='login-view']/div[1]/div[1]/h3")]
        public IWebElement Header_RSA;
        [FindsBy(How = How.XPath, Using = ".//*[@id='ctrl_input_000010']")]
        public IWebElement RSA1;

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctrl_input_000011']")]
        public IWebElement RSA2;

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctrl_input_000012']")]
        public IWebElement RSA3;

        [FindsBy(How = How.XPath, Using = ".//*[@id='login-view']/div[1]/div[2]/button[1]")]
        public IWebElement RSA_SubmitButton;
        

        public void RSA_Login()
        {
           // Thread.Sleep(20000);
            Browser.IsElementDisplayed(Header_RSA);
            RSA1.SendKeys("abc");
            RSA2.SendKeys("abc");
            RSA3.SendKeys("abc");
            RSA_SubmitButton.Click();

           /* if (oopsError1.Displayed)
            {
                oopsError1.Click();
                if (oopsError2.Displayed)
                {
                    oopsError2.Click();
                }
                else
                {
                    Console.WriteLine("No ooops error displayed");
                }
            }*/
        }
    }
}
