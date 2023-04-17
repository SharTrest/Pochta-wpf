using System.Collections.ObjectModel;

namespace Pochta.Model
{
    interface ITakeMessage
    {
        //public ObservableCollection<MessageModel> TakeAllMessages(ObservableCollection<MessageModel> Messages);
        public ObservableCollection<MessageModel> TakeAllMessages(ObservableCollection<MessageModel> Messages);
        string Domain();
    }
}
