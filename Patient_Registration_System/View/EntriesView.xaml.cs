using Patient_Registration_System.Model;
using Patient_Registration_System.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// Interaction logic for EntriesView.xaml
    /// </summary>
    public partial class EntriesView : UserControl
    {
        public EntriesView()
        {
            InitializeComponent();
        }

       public void Create()
        {
            using (UserDataContex contex = new UserDataContex())
            {
                int id = Convert.ToInt32(Idtxt.Text);
                var date = entrydatetxt.Text;
                var medicin = medicinrtxt.Text;
                var discribtion = discribtiontxt.Text;
                int amount= Convert.ToInt32(amoundtxt.Text);
                //EntryData entry = contex.entryDatas.Single(x =>  == id);
                if (id!=-1 && date!=null && medicin!=null && discribtion !=null && amount!=-1)
                {

                    UserViewModel userfound = contex.Users.FirstOrDefault(x =>x.UserId==id);
                    if(userfound!=null) 
                    {
                        var newEntry = new EntryData { Date = date, Madicine = medicin, Discribtion = discribtion, Amount = amount, PatientId = id };

                        UserViewModel user = contex.Users.Single(x => x.UserId == id);
                        user.entryDatas = new List<EntryData> { newEntry };
                        contex.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Invalide Id number");
                    }

                }
                else
                {
                    MessageBox.Show("Invalide Id number");
                }
                

            }
        }

        private void createBtn_Click(object sender, RoutedEventArgs e)
        {
            
            var date = entrydatetxt.Text;
            var medicin = medicinrtxt.Text;
            var discribtion = discribtiontxt.Text;
            
            //EntryData entry = contex.entryDatas.Single(x =>  == id);
            if ( date != "" && medicin != "" && discribtion != "")
            {
                Create();
                Idtxt.Text = "";
                entrydatetxt.Text = "";
                medicinrtxt.Text = "";
                discribtiontxt.Text = "";
                amoundtxt.Text = "";
            }
            else
            {
                MessageBox.Show("Enter all details!!!");
            }

        }
    }
}
