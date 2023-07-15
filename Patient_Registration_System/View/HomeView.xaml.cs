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
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public List<EntryData> DatabaseUsers { get; private set; }
        
        public HomeView()
        {
            InitializeComponent();
            DataContext = this;
            Read();

        }
        public void Delete()
        {
            
            using (UserDataContex contex = new UserDataContex())
            {
                EntryData? selectedUser = itemList.SelectedItem as EntryData;

                
                    if(selectedUser!= null)
                {
                    EntryData user = contex.entryDatas.Single(x => x.No == selectedUser.No);
                    contex.entryDatas.Remove(user);
                    contex.SaveChanges();
                    MessageBox.Show("Deleted");
                }
                    

                

            }

        }
     
        public int TotalRevenue
        {
            get { return Revenue.countRevenue(); }
        }
        public void Read()
        {
            using (UserDataContex contex = new UserDataContex())
            {
               
                DatabaseUsers=contex.entryDatas.ToList();
                itemList.ItemsSource=DatabaseUsers;
            }
        }

        

        private void readBtn_Click(object sender, RoutedEventArgs e)
        {
            Read();

        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            EditView editView = new EditView();
            editView.MyListView = itemList;
            editView.Show();


        }

        private void deltebtn_Click(object sender, RoutedEventArgs e)
        {
            Delete();
            

        }
    }
}
