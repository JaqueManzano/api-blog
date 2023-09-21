using System.Net;
using System.Net.Mail;

namespace Blogv2.Services
{
    public class EmailService
    {
        public bool Send(
            string ToName,
            string toEmail,
            string subject,
            string body,
            string fromName = "Equipe balta.io",
            string fromEmail = "email@balta.io")
        {
            var smtpClient = new SmtpClient(Configuration.Smtp.Host, Configuration.Smtp.Port);
            smtpClient.Credentials = new NetworkCredential(Configuration.Smtp.Username, Configuration.Smtp.Password);
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;

            var mail = new MailMessage();

            mail.From = new MailAddress(fromEmail, fromName);
            mail.To.Add( new MailAddress(toEmail, ToName));
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;

            try
            {
                smtpClient.Send(mail);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
