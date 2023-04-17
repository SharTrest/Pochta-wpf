using Pochta.Model;
using System.Threading;
using System.Windows;

namespace Pochta.ViewModel
{
    public class HomeViewModel:ViewModelBase
    {
        public HomeViewModel()
        {
            MessageBox.Show(Thread.CurrentPrincipal.Identity.Name, Thread.CurrentPrincipal.Identity.AuthenticationType);
        }

    }
}
