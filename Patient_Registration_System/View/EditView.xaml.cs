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
using System.Windows.Shapes;
using System.Xml.Linq;


namespace Patient_Registration_System.View
{
    /// <summary>
    /// Interaction logic for EditView.xaml
    /// </summary>
    public partial class EditView : Window
    {
        public ListView MyListView { get; set; }
        public EditView()
        {
            InitializeComponent();
        }

       

        public void Update()
        {

            using (UserDataContex contex = new UserDataContex())
            {
                EntryData selectData= MyListView.SelectedItem as EntryData;
                //var name = Enametxt.Text;
                int id= Convert.ToInt32(Eidtxt.Text);
                var date = Edatetxt.Text;
                var medicine = Emedicinetxt.Text;
                var discribtion = Emedicinetxt.Text;
                int amount = Convert.ToInt32(Eamounttxt.Text);
                if (id !=-1 && date != null && medicine != null && discribtion != null && amount != -1)
                {
                    EntryData user = contex.entryDatas.Find(selectData.No);
                    user.Discribtion= discribtion;
                    user.Amount= amount;
                    user.Date= date;
                    user.Madicine= medicine;
                    user.PatientId = id;
                    contex.SaveChanges();
                     MessageBox.Show("updated");

                }

                //UserViewModel selectedUser = MyListView.SelectedItem as UserViewModel;

                //var name = Enametxt.Text;
                //var dateofbirth = Edatetxt.Text;
                //var medicine = Emedicinetxt.Text;
                //var discribtion= Emedicinetxt.Text;
                //int amount= Convert.ToInt32(Eamounttxt.Text);

                //if (name != null && dateofbirth != null && medicine != null && discribtion != null && amount!=-1)
                //{
                //    UserViewModel user = contex.Users.Find(selectedUser.Id);
                //    user.Name = name;
                //    user.Date_of_birth = dateofbirth;
                //    //user.Discribtion = discribtion;
                //    //user.Madicine = medicine;
                //    //user.Amount = amount; 

                //    contex.SaveChanges();
                //    MessageBox.Show("updated");

                //}
                //else
                //{
                //    MessageBox.Show("Enter all values");
                //}

            }

        }

        private void Updatebtn_Click(object sender, RoutedEventArgs e)
        {
            Update();
            Eidtxt.Text="";
            Edatetxt.Text = "";
            Emedicinetxt.Text = "";
            Emedicinetxt.Text = "";
            Eamounttxt.Text="0";
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }

        }
    }
}
