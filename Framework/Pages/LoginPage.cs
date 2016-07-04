using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
namespace Framework.Pages
{
    public class LoginPage {

        [FindsBy(How = How.XPath, Using = ".//*[@id='inputFiId']")]
        public IWebElement FIID;

        [FindsBy(How = How.XPath, Using = ".//*[@id='inputID']")]
        public IWebElement LoginID;

        [FindsBy(How = How.XPath, Using = ".//*[@id='inputPassword']")]
        public IWebElement Password;

        [FindsBy(How = How.XPath, Using = ".//*[@id='login-view']/div/div[2]/button")]
        public IWebElement LoginButton;



        public void Goto(){
            Browser.Goto_BO("/#/login");
          //Thread.Sleep(1000);
        }

        public bool IsAt(){
            return Browser.Title.Contains("Jack Henry BackOffice");
        }
       
        public void Login(){
            //Thread.Sleep(2000);
            FIID.SendKeys("110618");
            LoginID.SendKeys("JhaAdmin");
            Password.SendKeys("password1");
            LoginButton.Click();
        }
    }
}