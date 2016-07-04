using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Mail;

namespace Framework
{
    public class TestBase
    {
        [TestInitialize]
        public static void Initialize()
        {
            Browser.Initialize_BO();
        }

        public static void TestFixtureTearDown()
        {
            Browser.Close();
        }

        public static void SendMail(string from, string to, string password)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress(from);
            mail.To.Add(to);
            mail.Subject = "Automation Test--Results";
            mail.Body = "Automation Test--Results__Body";

            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment("c:/JHA/textfile.txt");
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential(from, password);
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }

        [TestCleanup]
        public static void TearDown()
        {
            Browser.Close();
        }

        
    }
}
