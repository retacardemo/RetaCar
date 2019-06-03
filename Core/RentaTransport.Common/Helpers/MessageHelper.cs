using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using RentaTransport.Common.Responses;

namespace RentaTransport.Common.Helpers
{
    public class MessageHelper
    {
        public static ActionResponse SendEmail(string to, string subject, string message)
        {
            try
            {
                SmtpClient client = new SmtpClient()
                {
                    //your smtp server
                    Host = "smtp.gmail.com",
                    //your smtp server port
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    //your credentials(email and password)
                    Credentials = new System.Net.NetworkCredential("tebrizg57@gmail.com", "magistr2015"),
                    EnableSsl = true
                };

                MailMessage mailMessage = new MailMessage();
                //your email poster
                mailMessage.From = new MailAddress("tebrizg57@gmail.com");
                mailMessage.To.Add(to);
                mailMessage.Subject = subject;
                mailMessage.IsBodyHtml = true;
                mailMessage.Body = message;
                client.Send(mailMessage);
                return ActionResponse.Succeed();
            }
            catch (Exception ex)
            {
                return ActionResponse.Failure(ex.Message);
            }
        }
    }
}
