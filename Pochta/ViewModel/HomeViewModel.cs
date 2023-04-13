using Pochta.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pochta.ViewModel
{
    public class HomeViewModel:ViewModelBase
    {
        private readonly UserModel _user;
        public string Username
        {
            get 
            { 
                return _user.Username; 
            }
            set
            {
                _user.Username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        public string Password
        {
            get 
            { 
                return _user.Password; 
            }
            set 
            { 
                _user.Password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public HomeViewModel()
        {
            _user = new UserModel();
            
        }

    }
}
