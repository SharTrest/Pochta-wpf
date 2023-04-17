using System.Windows.Input;
using Pochta.Utilities;

namespace Pochta.ViewModel
{
    public class NavigationViewModel:ViewModelBase
    {
        private object _currentView;
        public object CurrentView
        {
            get 
            { 
            return _currentView;
            }
            set 
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public ICommand HomeCommand { get; set; }
        public ICommand SendMessageCommand { get; set;}
        public ICommand TakeMessagesCommand { get; set; }

        private void Home(object obj) => CurrentView = new HomeViewModel(); 
        private void SendMessage(object obj) => CurrentView = new SendMessageViewModel();
        private void TakeMessages(object obj) => CurrentView = new TakeMessagesViewModel();

        public NavigationViewModel() 
        {
            HomeCommand = new RelayCommand(Home);
            SendMessageCommand = new RelayCommand(SendMessage);
            TakeMessagesCommand = new RelayCommand(TakeMessages);

            //Стартовое окно
            CurrentView = new HomeViewModel();
        }

    }
}
    