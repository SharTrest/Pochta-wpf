using Pochta.Model;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Pochta.ViewModel
{
    public class TakeMessagesViewModel:ViewModelBase
    {
        public ObservableCollection<string> Messages { get; set; }

        private MessageModel _currentMessge;

        private TakeMessage TakeMessage;
        


        public ICommand TakeMessageCommand; 

        public string Email => _currentMessge.Email.ToString();


        public string Subject => _currentMessge.Subject.ToString();

        public string Body => _currentMessge.Body.ToString();

        public TakeMessagesViewModel()
        {
            //Messages = new ObservableCollection<MessageModel>();
            Messages = new ObservableCollection<string>();
            TakeMessage = new TakeMessage();
            //_currentMessge = new MessageModel();
            Messages = TakeMessage.TakeAllMessages(Messages);  

        }

        private bool CanExecuteTakeMessages(object arg)
        {
            throw new NotImplementedException();
        }

        private void ExecuteTakeMessages(object obj)
        {
            TakeMessage.ProcessingWithMessage(Email, Subject, Body);
        }
    }
}
