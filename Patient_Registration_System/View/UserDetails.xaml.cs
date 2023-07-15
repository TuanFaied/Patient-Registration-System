using Patient_Registration_System.Model;
using Patient_Registration_System.ViewModel;
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

namespace Patient_Registration_System.View
{
    /// <summary>
    /// Interaction logic for UserDetails.xaml
    /// </summary>
    public partial class UserDetails : UserControl
    {
        public List<UserViewModel> DataUser { get; private set; }
        public UserDetails()
        {
            InitializeComponent();
            DataContext = this;
            Read();
        }

        public int TotalUser
        {
            get { return CountUser.countUser(); }
        }
        private void userreadBtn_Click(object sender, RoutedEventArgs e)
        {
            Read();

        }

        private void userdeltebtn_Click(object sender, RoutedEventArgs e)
        {
            Delete();
        }
        public void Read()
        {
            using (UserDataContex contex = new UserDataContex())
            {

                DataUser = contex.Users.ToList();
                userList.ItemsSource = DataUser;
            }
        }
        public void Delete()
        {

            using (UserDataContex contex = new UserDataContex())
            {
                UserViewModel? selectedUser = userList.SelectedItem as UserViewModel;


                if (selectedUser != null)
                {
                    UserViewModel user = contex.Users.Single(x => x.UserId == selectedUser.UserId);
                    contex.Users.Remove(user);
                    contex.SaveChanges();
                    MessageBox.Show("Deleted");
                }




            }

        }

    }
}
