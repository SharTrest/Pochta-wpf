using Pochta.Model;
using Pochta.Utilities;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Pochta.ViewModel
{

    public class SendMessageViewModel:ViewModelBase
    {
        private string _email;
        private string _text;
        private string _subject;

        private SendMessage _sendMesage;

        public ICommand SendMessageCommand { get; }

        public string Email
        {
            get { return _email; }
            set { _email = value; OnPropertyChanged(nameof(Email)); }
        }

        public string Text
        {
            get { return _text; }
            set { _text = value; OnPropertyChanged(nameof(Text)); }
        }

        public string Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged(nameof(Subject)); }
        }

        public SendMessageViewModel()
        {
            _sendMesage = new SendMessage();
            SendMessageCommand = new RelayCommand(ExecuteSendMessageCommand, CanExecuteSendMesageCommand);
        }

        private bool CanExecuteSendMesageCommand(object obj)
        {
            return true;
        }

        private void ExecuteSendMessageCommand (object obj)
        {
            _sendMesage.MessageSend(Email, Subject, Text);
        }

        
    }
}
