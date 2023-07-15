using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Registration_System.ViewModel
{
    public class CompositeViewModel : ViewModelBase
    {
        public MainViewModel mainViewModel { get; set; }
        public AdminViewModel adminViewModel { get; set; }

        public UserViewModel userViewModel { get; set; }
        public CompositeViewModel()
        {
            userViewModel= new UserViewModel();
            mainViewModel = new MainViewModel();
            adminViewModel = new AdminViewModel();
        }
    }
}
