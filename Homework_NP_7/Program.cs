using MailKit.Net.Pop3;
using MimeKit;
using System.Net;
using System.Net.Mail;

namespace Homework_NP_7
{
    public class Program
    {
        static void Main()
        {
            //Реализовать приложение по типу «Console Application», с возможность отправки письма нескольким получателям.

            //List<string> recipients = new List<string>();


            //MailAddress from = new MailAddress("liliya.kuchernyuk713@gmail.com");
            //MailMessage message = new MailMessage()
            //{
            //    Subject = "Test Message",
            //    Body = "<h2>Mail test of smtp client operation</h2>",
            //    IsBodyHtml = true,
            //    From = from
            //};

            //foreach (string recipient in recipients)
            //{
            //    message.To.Add(recipient);
            //}

            //SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            //smtp.Credentials = new NetworkCredential("liliya.kuchernyuk713@gmail.com", "ijmf jrku kkgk kdib");
            //smtp.EnableSsl = true;
            //smtp.Send(message);

            //---------------------------------------------


            //1. Используя код из предыдущего задания, реализовать возможно прикреплять вложения, указывая путь к ним.
            //List<string> recipients = new List<string>();


            //MailAddress from = new MailAddress("liliya.kuchernyuk713@gmail.com");
            //MailMessage message = new MailMessage()
            //{
            //    Subject = "Test Message",
            //    Body = "<h2>Mail test of smtp client operation</h2>",
            //    IsBodyHtml = true,
            //    From = from
            //};

            //Attachment attachment = new Attachment(@"C:\Users\user\Desktop\git.txt");
            //message.Attachments.Add(attachment);

            //foreach (string recipient in recipients)
            //{
            //    message.To.Add(recipient);
            //}

            //SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            //smtp.Credentials = new NetworkCredential("liliya.kuchernyuk713@gmail.com", "ijmf jrku kkgk kdib");
            //smtp.EnableSsl = true;
            //smtp.Send(message);

            //-----------------------------


            //2. Используя протокол «POP3», получить все письма с вашего почтового ящика.

            //string pop3Server = "pop.gmail.com";
            //int port = 995;//порт РОР3 с SSL
            //string userName = "liliya.kuchernyuk713@gmail.com";
            //string password = "ijmf jrku kkgk kdib";
            //try
            //{
            //    using (var client = new Pop3Client())
            //    {
            //        client.Connect(pop3Server, port, true);//используем SSL
            //        client.Authenticate(userName, password);
            //        int count = client.Count;
            //        Console.WriteLine($"Total message: {count}");

            //        for (int i = 0; i < count; i++)
            //        {
            //            MimeMessage message = client.GetMessage(i);
            //            Console.WriteLine($"Subject: {message.Subject}");
            //        }
            //        client.Disconnect(true);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}


        }
    }
}
