using System.Net;
using System.Net.Mail;

namespace Homework_NP_7
{
    public class Program
    {
        static void Main()
        {
            List<string> recipients = new List<string>();


            MailAddress from = new MailAddress("somemail@gmail.com", "Tom");
            MailMessage message = new MailMessage()
            {
                Subject = "Test Message",
                Body = "<h2>Mail test of smtp client operation</h2>",
                IsBodyHtml = true,
                From = from
            };

            foreach (string recipient in recipients)
            {
                message.To.Add(recipient);
            }

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("somemail@gmail.com", "Application Password");
            smtp.EnableSsl = false;
            smtp.Send(message);
        }
    }
}
