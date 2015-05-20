using System.Configuration;
using System.Net.Mail;

namespace CustomerSurvey.Helpers
{
    public static class EmailHelper
    {
        public static void SendEmail(string to, string url)
        {
            MailMessage objeto_mail = new MailMessage();
            SmtpClient client = new SmtpClient();
            client.Port = 25;
            client.Host = CookieHelper.GetCookie("SMTP.Host") ?? ConfigurationManager.AppSettings["Defaults.SMTP.Host"];
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(CookieHelper.GetCookie("SMTP.UserName") ?? ConfigurationManager.AppSettings["Defaults.SMTP.UserName"], CookieHelper.GetCookie("SMTP.Password") ?? ConfigurationManager.AppSettings["Defaults.SMTP.Password"]);
            objeto_mail.From = new MailAddress(CookieHelper.GetCookie("SMTP.From") ?? ConfigurationManager.AppSettings["Defaults.SMTP.From"]);
            objeto_mail.To.Add(new MailAddress(to));
            objeto_mail.Subject = "Please remove links";
            objeto_mail.Body = "Remove links from " + url;
            client.Send(objeto_mail);
        }
    }
}