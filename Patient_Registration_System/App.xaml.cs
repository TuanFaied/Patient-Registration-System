using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Patient_Registration_System.View;
using Patient_Registration_System.ViewModel;

namespace Patient_Registration_System
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            DatabaseFacade facade = new DatabaseFacade(new UserDataContex());
            facade.EnsureCreated();

            //base.OnStartup(e);
            //ShareViewModel viewModel = new ShareViewModel();
            ////this.MainWindow.DataContext = viewModel;
            //LoginView mainWindow = new LoginView();
            //mainWindow.DataContext = viewModel;
            //this.MainWindow = mainWindow;

           // mainWindow.Show();
        }
        //public static ShareViewModel ViewModel { get; } = new ShareViewModel();
    }
}
