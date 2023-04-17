using Pochta.Model;
using Pochta.Utilities;
using System.Threading;
using System.Windows;

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
            LoadCurrentData();
        }

        private void LoadCurrentData()
        {
            MessageBox.Show(Thread.CurrentPrincipal.Identity.Name, Thread.CurrentPrincipal.Identity.AuthenticationType);
        }
    }
}
