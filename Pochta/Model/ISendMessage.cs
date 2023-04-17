namespace Pochta.Model
{
    public interface ISendMessages
    {
        public void MessageSend(string Email, string textSubject, string textMessage);
        string Domain();
    }
}
