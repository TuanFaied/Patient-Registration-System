using Patient_Registration_System.Model;
using Patient_Registration_System.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace Patient_Registration_System.View
{
    /// <summary>
    /// Interaction logic for UserView.xaml
    /// </summary>
    public partial class UserView : Window
    {
       // public string ValueToPass { get; set; }
        public UserView(string name)
        {
            
            //var windo = new LoginView();
            //string name = windo.loginUserName();

            InitializeComponent();
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            using (UserDataContex db = new UserDataContex())
            {
                var imagedata = db.Users.FirstOrDefault(x=> x.Name==name)?.ImageUser;
                var image = new BitmapImage();
                using (var stream = new MemoryStream(imagedata))
                {
                    image.BeginInit();
                    image.CacheOption = BitmapCacheOption.OnLoad;
                    image.StreamSource = stream;
                    image.EndInit();
                }

                MyImageControl.ImageSource = image;
            }
            
            UserNameTextBlock.Text =name;
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
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
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

    }
}
