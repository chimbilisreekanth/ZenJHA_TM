using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Framework.BO_Pages
{
    public class SearchCompanyPage
    {

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctrl_dropdown_00001']")]
        public IWebElement CompSearch_DD;

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctrl_textbox_00001']")]
        public IWebElement CompSearch_textbox;

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctrl_button_5']")]
        public IWebElement CompSearch_button;
        

        public void selectDDValueText(){
            SelectElement se = new SelectElement(CompSearch_DD); //Locating select list
            se.SelectByText("CIF Number");
        }

        public void SrearchCompanyByCIF()
        {
          //  Thread.Sleep(20000);
            selectDDValueText();
            CompSearch_textbox.SendKeys("TAA0015");
            CompSearch_button.Click();
        }
    }
}
