using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Pksrch
{
    internal class CodeMail
    {
        int code;
        string mail;
        public void CodeInit()
        {
            Random r = new Random();
            code = r.Next(100000, 999999);
                        
            
            Console.WriteLine("Введите вашу почту");
            string mail = Console.ReadLine();

            MailAddress from = new MailAddress("artyom.grechko.dl@yandex.ru", "Артемидзе");
            MailAddress to = new MailAddress(mail);

            MailMessage message = new MailMessage(from, to);
            message.Subject = "Код подтверждения";
            message.Body = "<h4>Данное письмо сгенерировано роботом автоматически. Пожалуйста, не отвечайте на него.</h4>" + "Ваш код подтверждения: " + code.ToString();
            message.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.yandex.ru";
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;            
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("artyom.grechko.dl@yandex.ru", "c1b5rS1r");
            smtp.Send(message);
            
        }

        public void verify()
        {
            while (true)
            {
                Console.WriteLine("Введите код: ");
                if (Console.ReadLine() == code.ToString())
                {
                    Console.WriteLine("Регистрация завершена");
                    break;
                }
                else
                {
                    Console.WriteLine("Введён неправильный код");
                    verify();
                }
            }
        }
    }
}
