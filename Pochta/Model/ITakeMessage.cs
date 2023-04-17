using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pochta.Model
{
    interface ITakeMessage
    {
        //public ObservableCollection<MessageModel> TakeAllMessages(ObservableCollection<MessageModel> Messages);
        public ObservableCollection<string> TakeAllMessages(ObservableCollection<string> Messages);
        string Domain();
    }
}
