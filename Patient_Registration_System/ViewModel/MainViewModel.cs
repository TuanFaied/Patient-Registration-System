
using MahApps.Metro.IconPacks;
using Patient_Registration_System.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Patient_Registration_System.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase _currentChildView;
        private string _caption;
        public  TextBox texUser;

        public ViewModelBase CurrentChildView 
        {
            get
            {
                return _currentChildView;
            }
            set
            {
                _currentChildView = value;
                OnPropertyChanged(nameof(CurrentChildView));
            } 
        }
        public string Caption 
        {
            get
            {
                return _caption;
            } 
            set
            {
                _caption = value;
                OnPropertyChanged(nameof(Caption));
            } 
        }
        
        //commands
        public ICommand ShowHomeViewCommand { get; }
      //  public ViewModelCommand ShowRegistrationViewCommand { get; }
        public ICommand ShowRegistrationViewCommand { get; }
        public ICommand ShowEntriesViewCommand { get; }
        public ICommand ShowAdminSettingViewCommand { get; }
        public ICommand ShowUserSetingViewCommand { get; }
        public ICommand ShowUserHomeViewCommand { get; }
        public ICommand ShowUserDetailsViewCommand { get; }

        
        
        public MainViewModel()
        {
            texUser = new TextBox();
            Action<object> wrappedAction = (parameter) => ExecuteShowUserSetingViewCommandWithTextBox(parameter, texUser);
            ShowUserSetingViewCommand = new ViewModelCommand(wrappedAction);

            Action<object> wrappedAction1 = (parameter) => ExecuteShowUserHomeViewCommandWithTextBox(parameter, texUser);
            ShowUserHomeViewCommand = new ViewModelCommand(wrappedAction1);

            //initialize commands
            ShowHomeViewCommand = new ViewModelCommand(ExecuteShowHomeViewCommand);
            ShowRegistrationViewCommand = new ViewModelCommand(ExecuteShowRegistrationViewCommand);
            ShowEntriesViewCommand = new ViewModelCommand(ExecuteShowEntriesViewCommand);
            ShowAdminSettingViewCommand = new ViewModelCommand(ExecuteShowAdminSettingViewCommand);
         ////  ShowUserSetingViewCommand = new ViewModelCommand(ExecuteShowUserSetingViewCommand);
         ////   ShowUserHomeViewCommand = new ViewModelCommand(ExecuteShowUserHomeViewCommand);
            ShowUserDetailsViewCommand= new ViewModelCommand(ExecuteShowUserDetailsViewCommand);
           
           // ShowUserSetingViewCommand = new ViewModelCommand(ExecuteShowUserSetingViewCommandWithTextBox);
            //default
            //ExecuteShowHomeViewCommand();
        }

       

        private void ExecuteShowUserHomeViewCommandWithTextBox(object obj, TextBox texUser)
        {
            string username = texUser.Text;
            CurrentChildView = new UserHomeViewModel(username);
            Caption = "Dashboard";
        }

        private void ExecuteShowUserSetingViewCommandWithTextBox(object obj, TextBox texUser)
        {
            string username = texUser.Text;
            CurrentChildView = new UserSettingViewModel(username);
            Caption = "Settings";
        }
        private void ExecuteShowUserDetailsViewCommand(object obj)
        {
            CurrentChildView = new UserDetailViewModel();
            Caption = "Patient's Details";
        }

/*        private void ExecuteShowUserHomeViewCommand(object obj)
        {
            //string username = texUser.Text;
            CurrentChildView = new UserHomeViewModel();
            Caption = "Dashboard";
        }

        private void ExecuteShowUserSetingViewCommand(object obj)
        {
        //    string username = texUser.Text;
            CurrentChildView = new UserSettingViewModel();
            Caption = "Settings";
        }*/

        private void ExecuteShowAdminSettingViewCommand(object obj)
        {
            CurrentChildView = new AdminSettingViewModel();
            Caption = "Settings";
        }

        private void ExecuteShowEntriesViewCommand(object obj)
        {
            CurrentChildView = new EntriesViewModel();
            Caption = "Entries";

        }

        private void ExecuteShowRegistrationViewCommand(object obj)
        {
            CurrentChildView = new RegistrationViewModel();
            Caption = "Registration";
            
        }

        private void ExecuteShowHomeViewCommand(object obj)
        {
            CurrentChildView = new HomeViewModel();
            Caption = "Dashboard";
            
        }
    }
}
