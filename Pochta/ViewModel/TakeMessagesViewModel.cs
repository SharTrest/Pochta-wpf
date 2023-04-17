using Pochta.Model;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace Pochta.ViewModel
{
    public class TakeMessagesViewModel:ViewModelBase
    {
        public ObservableCollection<MessageModel> _messages;
        private TakeMessage TakeMessage;

        private string _email, _subject, _body;
        
        public ObservableCollection<MessageModel> Messages
        {
            get => _messages;
            set
            {
                _messages = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        public string Subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged();
            }
        }

        public string Body
        {
            get => _body;
            set
            {
                _body = value;
                OnPropertyChanged();
            }
        }

        public ICommand TakeMessageCommand; 

        public TakeMessagesViewModel()
        {
            TakeMessage = new TakeMessage();
            Messages = new ObservableCollection<MessageModel>();
            Messages = TakeMessage.TakeAllMessages(Messages);
        }

        private bool CanExecuteTakeMessages(object arg)
        {
            throw new NotImplementedException();
        }

    }
}
