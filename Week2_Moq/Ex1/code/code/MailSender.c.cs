using System.Net;
using System.Net.Mail;


namespace code
{
    public class MailSender : IMailSender
    {
        public bool SendMail(string toAddress, string message)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("your_email_address@gmail.com");
                mail.To.Add(toAddress);
                mail.Subject = "Test Mail";
                mail.Body = message;

                smtpServer.Port = 587;
                smtpServer.Credentials = new NetworkCredential("username", "password");
                smtpServer.EnableSsl = true;

                smtpServer.Send(mail);
                return true;
            }
            catch
            {
                // If any error occurs while sending mail
                return false;
            }
        }
    }
}
