using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Pochta.Model
{
    internal class SendMessage : ISendMessages
    {
        public string Domain()
        {
            string username = Thread.CurrentPrincipal.Identity.Name;
            int k = 0;
            string smtp = null;
            foreach (char s in username)
            {
                if (k == 1)
                    smtp += s.ToString();
                if (s == '@')
                    k = 1;
            }
            if (string.IsNullOrEmpty(smtp))
                return "error";
            else return smtp;
        }


        public void MessageSend(string Email, string textSubject, string textMessage)
        {
            string username = Thread.CurrentPrincipal.Identity.Name;
            string password = Thread.CurrentPrincipal.Identity.AuthenticationType;

            string smtp = "smtp." + Domain();

            SmtpClient smtpClient = new SmtpClient("smtp.rambler.ru");

            try
            {
                smtpClient.UseDefaultCredentials = false;
                System.Net.NetworkCredential Authentificator = new System.Net.NetworkCredential(username, password);
                smtpClient.Credentials = Authentificator;
                MailAddress from = new MailAddress(username, username);
                MailAddress to = new MailAddress(Email, Email);
                MailMessage message = new MailMessage(from, to);

                message.Subject = textSubject;
                message.Body = textMessage;

                smtpClient.Send(message);

                MessageBox.Show("Сообщение отправлено");
            }
            catch
            {
                MessageBox.Show("Ошибка отправления");
            }
        }
    }
}
