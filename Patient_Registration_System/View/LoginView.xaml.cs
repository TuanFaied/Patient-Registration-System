using Microsoft.EntityFrameworkCore;
using Patient_Registration_System.Model;
using Patient_Registration_System.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace Patient_Registration_System.View
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            
            InitializeComponent();
           
          
        }
        

        

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }

        }

        private void minimizebutton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void closebutton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void userBtn_Click(object sender, RoutedEventArgs e)
        {
            string Username = texUser.Text;
            var Password = password.Password;
            using (var context = new UserDataContex())
            {
                bool userfound = context.Users.Any(user => user.Name == Username && user.Password == Password);
                var user = context.Users.FirstOrDefault(x => x.Name == Username && x.Password == Password);
                if (userfound)
                {
                    UserSettingView userSettingView = new UserSettingView(Username);
                    UserHomeView userHomeView = new UserHomeView(Username);
                    
                    //userHomeView.DataContext = new UserSettingViewModel(Username);
                    //userHomeView._Username = Username;
                    GrantAccess1(Username);
                   
                    Close();
                }
                else
                {
                    MessageBox.Show("User Not Found or Password Incorrect");
                }


            }
            

        }

        public void GrantAccess1(string name)
        {
           
            UserView main1 = new UserView(name);
           
            main1.Show();
        }
        public void GrantAccess()
        {
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void adminBtn_Click(object sender, RoutedEventArgs e)
        {
            var Username = texUser.Text;
            var Password = password.Password;
            
            using (UserDataContex contex = new UserDataContex())
            {
                bool userfound = contex.Admins.Any(user => user.A_Name == Username && user.A_Password == Password);
                bool son= userfound;
                if (userfound)
                {
                    GrantAccess();
                    Close();
                }
                else
                {
                    MessageBox.Show("User Not Found");
                }
            }
        }

        private void texUser_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
//using (UserDataContex contex= new UserDataContex())
//{

//    bool userfound = contex.Users.Any(user => user.Name == Username && user.Password == Password);
//   var user= contex.Users.FirstOrDefault(x=> x.Name== Username && x.Password == Password);
//   bool son = userfound;
//   
//}

//using (var transaction = context.Database.BeginTransaction())
//{
//    try
//    {
//        // Perform database operations here
//        context.saveUsers.Add(new SaveUser() { _userName = user.Name, _password = user.Password });
//        context.SaveChanges();

//        transaction.Commit(); // Commit the transaction
//    }
//    catch (Exception ex)
//    {
//        transaction.Rollback(); // Rollback the transaction if an exception occurs
//        MessageBox.Show(ex.Message);
//    }
//}