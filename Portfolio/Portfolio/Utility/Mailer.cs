using Portfolio.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Portfolio.Utility
{
    public class Mailer : IMailer
    {
        public void SendEmail(string from, string fromName, string to, string toName, string password, string mailSubject, string mailBody)
        {
            var fromAddress = new MailAddress(from, fromName);
            var toAddress = new MailAddress(to, toName);
            var fromPassword = password;
            var subject = mailSubject;
            var body = mailBody;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                Timeout = 20000
            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }



    }
}
