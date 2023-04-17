using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Pochta.ViewModel
{
    public class SendMessageViewModel
    {
        public SendMessageViewModel()
        {
            MessageBox.Show(Thread.CurrentPrincipal.Identity.Name, Thread.CurrentPrincipal.Identity.AuthenticationType);
        }
    }
}
