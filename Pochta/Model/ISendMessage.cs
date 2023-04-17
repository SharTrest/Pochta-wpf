using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pochta.Model
{
    public interface ISendMessages
    {
        public void MessageSend(string Email, string textSubject, string textMessage);
        string Domain();
    }
}
