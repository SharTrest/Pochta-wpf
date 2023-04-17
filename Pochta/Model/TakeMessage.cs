using System;
using Limilabs.Client.IMAP;
using Limilabs.Mail.Headers;
using Limilabs.Mail;
using Limilabs.Mail.Fluent;
using System.Collections.Generic;
using System.Windows;
using System.Collections.ObjectModel;
using System.Threading;

namespace Pochta.Model
{
    public class TakeMessage : ITakeMessage
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

        public ObservableCollection<string> TakeAllMessages(ObservableCollection<string> Messages)
        {
                Messages.Clear();
                using (Imap imap = new Imap())
                {
                    string imp = "imap." + Domain();
                    imap.Connect(imp);
                    try
                    {
                        imap.Login(Thread.CurrentPrincipal.Identity.Name, Thread.CurrentPrincipal.Identity.AuthenticationType);
                        imap.SelectInbox();
                        List<long> uids = imap.Search(Flag.All);
                        foreach (long uid in uids)
                        {
                            var eml = imap.GetMessageByUID(uid);
                            IMail email = new MailBuilder()
                                .CreateFromEml(eml);
                            // From
                            string subj = email.Subject.ToString();
                            string body = email.Text.ToString();
                            int i = 0;
                            foreach (MailBox m in email.From)
                            {
                            var message = new MessageModel
                            {
                                Email = m.Address,
                                Subject = subj,
                                Body = body
                            };

                            Messages.Add(message.Email);
                            Messages.Add(message.Subject);
                            Messages.Add(message.Body);
                            }
                        }
                    }
                    catch
                    {
                    }
                    imap.Close();
                }
            return Messages;
        }

        public void ProcessingWithMessage(string Email, string textSubject, string textMessage)
        {
            throw new NotImplementedException();
        }
    }
}
