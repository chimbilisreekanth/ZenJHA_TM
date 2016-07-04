using System.Dynamic;
using OpenQA.Selenium.Support.PageObjects;
using Framework.BO_Pages;

namespace Framework.Pages
{
    public class AllPages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);
            return page;
        }

        public static LoginPage LoginPage
        {
            get { return GetPage<LoginPage>(); }
        }

        public static RSAPage RSAPage
        {
            get { return GetPage<RSAPage>(); }
        }
        public static SearchCompanyPage SearchCompanyPage
        {
            get { return GetPage<SearchCompanyPage>(); }
        }

        // Channel pages
        public static CH_LoginPage CH_LoginPage
        {
            get { return GetPage<CH_LoginPage>(); }
        }
        public static CH_DashBoard CH_DashBoard
        {
            get { return GetPage<CH_DashBoard>(); }
        }
        public static CH_IR CH_IR
        {
            get { return GetPage<CH_IR>(); }
        }
        public static CH_InternalTransfer CH_InternalTransfer
        {
            get { return GetPage<CH_InternalTransfer>(); }
        }
        
        
    }
}