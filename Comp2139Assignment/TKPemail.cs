using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;

namespace Comp2139Assignment
{
    public static class TKPemail
    {
        public static void sendEmail(string toAddress, string subject, string body)
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.To.Add(toAddress);
            msg.From = new MailAddress("tech.know.pro.app@gmail.com", "Email head", System.Text.Encoding.UTF8);
            msg.Subject = subject;
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = body;
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.High;
            SmtpClient TKPemail = new SmtpClient();
            TKPemail.Host = "smtp.gmail.com";
            TKPemail.Port =  587;
            TKPemail.EnableSsl = true;
            TKPemail.DeliveryMethod = SmtpDeliveryMethod.Network;
            TKPemail.UseDefaultCredentials = false;
            TKPemail.Credentials = new NetworkCredential("tech.know.pro.app@gmail.com", "%#DYh9)$(0qww294e");
            try
            {
                TKPemail.Send(msg);
            }
            catch
            {
                // do something 
            }
        }
    }
}