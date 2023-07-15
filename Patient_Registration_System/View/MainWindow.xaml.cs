using Patient_Registration_System.View;
using System;
using System.Collections.Generic;
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
using Microsoft.EntityFrameworkCore;
using Patient_Registration_System.ViewModel;
using System.Xml.Linq;
using System.IO;

namespace Patient_Registration_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;

            string userName = "";
            using(UserDataContex context = new UserDataContex())
            {
                AdminViewModel currentUser= context.Admins.FirstOrDefault(x=> x.Id==1);
                if(currentUser!=null)
                {
                    userName = currentUser.A_Name;
                }
                var imagedata = currentUser.ImageAdmin;
                var image = new BitmapImage();
                using (var stream = new MemoryStream(imagedata))
                {
                    image.BeginInit();
                    image.CacheOption = BitmapCacheOption.OnLoad;
                    image.StreamSource = stream;
                    image.EndInit();
                }

                MyImageControl1.ImageSource = image;

            }
            UserNameTextBlock.Text = userName;
        }

        private void pnlControlBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void maximizeBtn_Click(object sender, RoutedEventArgs e)
        {
           if(this.WindowState==WindowState.Normal)
            {
                this.WindowState= WindowState.Maximized;
            }
           else this.WindowState = WindowState.Normal;
        }

        private void minimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        

        private void logOut_Click(object sender, RoutedEventArgs e)
        {
            LoginView loginView = new LoginView();
            loginView.Show();
            Close();

        }

        private void powerbtn_Click(object sender, RoutedEventArgs e)
        {
            LoginView loginView = new LoginView();
            loginView.Show();
            Close();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
