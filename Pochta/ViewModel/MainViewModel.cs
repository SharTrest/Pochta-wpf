using Pochta.Model;
using Pochta.Utilities;

namespace Pochta.ViewModel
{
    public class MainViewModel: ViewModelBase
    {
        private UserModel _user;
        private UserAuth _userAuth;

        public UserModel User
        {
            get 
            { 
                return _user; 
            }
            set 
            { 
                _user = value; 
                OnPropertyChanged(nameof(User));
            }

        }
        public MainViewModel() 
        {
            _userAuth = new UserAuth();
        }

    }
}
