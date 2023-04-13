using Pochta.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Limilabs.Client.IMAP;
using Limilabs.Mail.Headers;
using Limilabs.Mail;
using System.Net;
using Limilabs.Mail.Fluent;

namespace Pochta.Utilities
{
    public class UserAuth : IUser
    {
        public bool AuthentificateUser(NetworkCredential credential)
        {
            using (Imap imap = new Imap())
            {

                string imp = "imap." + Domain(credential.UserName);

                try
                {
                    imap.Connect(imp);
                    credential.Domain = Domain(credential.UserName);
                    imap.Login(credential.UserName, credential.Password);
                }

                catch
                {
                    return false;
                }
            }
            return true;
        }

        public string Domain(string Username)
        {
            int k = 0;
            string smtp = null;
            foreach (char s in Username)
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

        public void Remove()
        {
            
        }
    }
}
