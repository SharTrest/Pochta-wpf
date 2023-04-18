using Pochta.Utilities;
using System;
using System.Threading;
using System.Windows;
using System.Windows.Input;

namespace Pochta.ViewModel
{
    public class HomeViewModel:ViewModelBase
    {
        private string _username;

        private bool _isViewVisible = true;
        public bool IsViewVisible
        {
            get => _isViewVisible;
            set
            {
                _isViewVisible = value;
                OnPropertyChanged(nameof(IsViewVisible));
            }
        }



        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged();
            }
        }

        public ICommand ChangeUserCommand { get; }

        public HomeViewModel()
        {
            Username = Thread.CurrentPrincipal.Identity.Name;
           // ChangeUserCommand = new RelayCommand(ExecuteChangeUserCommand, CanExecuteChangeUserCommand);
        }

        private bool CanExecuteChangeUserCommand(object arg)
        {
            MessageBox.Show("Вы действительно хотите поменять пользователя?");
            return true;
        }

        private void ExecuteChangeUserCommand(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
