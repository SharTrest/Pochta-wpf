using Pochta.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Pochta.ViewModel
{
    public class TakeMessagesViewModel:ViewModelBase
    {
        ObservableCollection<MessageModel> Messages;
        public TakeMessagesViewModel()
        {
           
        }
    }
}
