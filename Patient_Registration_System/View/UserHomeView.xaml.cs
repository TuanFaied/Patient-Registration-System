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
    /// Interaction logic for UserHomeView.xaml
    /// </summary>
    public partial class UserHomeView : UserControl
    {
        public List<EntryData> DatabaseUsers { get; private set; }
        //   public string[] _name = new string[1];
        //  public string _Username { get; set; }
        private readonly string _name;
        public UserHomeView()
        {
            InitializeComponent();
        }
        public UserHomeView(string Name)
        {
            InitializeComponent();
           // DataContext = new UserHomeView(Name);
            _name = Name;
            using (UserDataContex contex = new UserDataContex())
            {
                SaveUser saveid = contex.saveUsers.FirstOrDefault(x => x.SaveId==1);
                saveid._userName=Name;
                contex.SaveChanges();
                
                
            }
         //    Read(Name);
         //  readBtn.Tag = Name;

        }
        public void Read()
        {

            using (UserDataContex contex = new UserDataContex())
            {

                
                SaveUser saveid = contex.saveUsers.FirstOrDefault(x => x.SaveId == 1);
                int? userId = contex.Users.FirstOrDefault(x => x.Name == saveid._userName)?.UserId;
                if (userId != null)
                {
                    DatabaseUsers = contex.entryDatas.Where(x => x.PatientId == userId).ToList();
                    itemList1.ItemsSource = DatabaseUsers;
                }
                // EntryData user = contex.entryDatas.Single(x => x.UserViewmodel.Name == Uname);
                else
                {
                    MessageBox.Show("You have no datas");
                }


            }
        }
        public void Delete()
        {

            using (UserDataContex contex = new UserDataContex())
            {
                EntryData? selectedUser = itemList1.SelectedItem as EntryData;


                if (selectedUser != null)
                {
                    EntryData user = contex.entryDatas.Single(x => x.No == selectedUser.No);
                    contex.entryDatas.Remove(user);
                    contex.SaveChanges();
                    MessageBox.Show("Deleted");
                }




            }

        }


      



        public void readBtn_Click(object sender, RoutedEventArgs e)
        {
           // DataContext = new UserSettingViewModel(_name);
            
            
            Read();

        }

       

        private void deltebtn_Click(object sender, RoutedEventArgs e)
        {
            Delete();


        }

       
    }
}
