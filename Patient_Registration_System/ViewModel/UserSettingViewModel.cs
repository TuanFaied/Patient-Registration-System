using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Patient_Registration_System.ViewModel
{
    public class UserSettingViewModel : ViewModelBase
    {
        private string _username;

        public UserSettingViewModel(string username)
        {
            _username = username;
        }
    }
}
