using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Pochta.ViewModel
{
    public class LoginViewModel:ViewModelBase
    { 
        //поля
        private string _username;
        private SecureString _password;
        private string _errorMessage;
        private bool _isViewVisible = true;

        public string Username
        {
            get 
            { 
                return _username; 
            }
            set 
            { 
                _username = value;
                OnPropertyChanged(nameof(Username));    
            }
        }

        public SecureString Password
        {
            get 
            { 
                return _password; 
            }
            set 
            { 
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public string ErrorMessage
        {
            get
            {
                return _errorMessage;
            }
            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }
        public bool IsViewVisible
        {
            get { return _isViewVisible; }
            set
            {
                _isViewVisible = value;
                OnPropertyChanged(nameof(IsViewVisible));
            }
        }

        //команды
        public ICommand LoginCommand { get; }
        public ICommand ShowPasswordCommand { get; }

        //
        public LoginViewModel()
        {
            LoginCommand = new ViewModelCommand(ExucuteLoginCommand, CanExecuteLoginCommand);   
        }

        private bool CanExecuteLoginCommand(object obj)
        {
            bool validData;
            if (string.IsNullOrWhiteSpace(Username) || Username.Length < 7 || Password == null || Password.Length < 5)
                validData = false;
            else 
                validData = true;
            return validData;
        }

        private void ExucuteLoginCommand (object obj)
        {

        }
    }
}
