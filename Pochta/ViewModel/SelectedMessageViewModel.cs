using Pochta.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Pochta.ViewModel
{
    public class SelectedMessageViewModel:ViewModelBase
    {
        public MessageModel Message { get; set; }


        public string _email;
        public string _subject;
        public string _body;

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



        public ICommand SelectMessageCommand;

        public SelectedMessageViewModel()
        {
            Message = new MessageModel();

        }

    }
}
