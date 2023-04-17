using System.Net;

namespace Pochta.Model
{
    public interface IUser
    {
        bool AuthentificateUser(NetworkCredential credential);
    }
}
