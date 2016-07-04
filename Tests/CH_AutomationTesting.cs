using System;
using Framework;
using Framework.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace Tests
{
    [TestClass]
    public class CH_AutomationTesting : TestBase{
        string currentDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        //[TestMethod, Priority(1), TestCategory("Smoke")]
         [TestMethod, Priority(1)]
          public void CH_Login()
          {
              AllPages.CH_LoginPage.Goto();
              AllPages.CH_LoginPage.CH_Login();
              AllPages.RSAPage.RSA_Login();
          }
          /*[TestMethod, Priority(2)]
          public void CH_ResearchTransactions()
          {
              AllPages.CH_DashBoard.Goto_RT();
          } */
        /* [TestMethod, Priority(4)]
         public void CH_InformationReporting()
         {
             AllPages.CH_IR.Goto_IR();
             AllPages.CH_IR.Exe_standardReport();
             Thread.Sleep(5000);
             AllPages.CH_IR.Goto_IR();
             Thread.Sleep(5000);
             AllPages.CH_IR.Exe_MyReport();
         }*/
        [TestMethod, Priority(3)]
         public void CH_Createtransfers()
         {
             AllPages.CH_DashBoard.Goto_Transfers();
             AllPages.CH_InternalTransfer.CreateTransfer();
         }    
    }
}


