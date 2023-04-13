using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Pochta.Model
{
    public interface IUser
    {
        bool AuthentificateUser(NetworkCredential credential);
        string Domain(string Username);
        void Remove();  
    }
}
