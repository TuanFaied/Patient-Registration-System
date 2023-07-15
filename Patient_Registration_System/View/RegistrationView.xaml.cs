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
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System.IO;

namespace Patient_Registration_System.View
{
    /// <summary>
    /// Interaction logic for RegistrationView.xaml
    /// </summary>
    public partial class RegistrationView : UserControl
    {
        public RegistrationView()
        {
            InitializeComponent();
           
            
        }

        public void Adduser()
        {
            MessageBox.Show("Select User Profile photo");
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.bmp; *.png; *.jpg";
            dialog.FilterIndex = 1;
            if (dialog.ShowDialog() == true)
            {

                // Load the image data into a memory stream
                var memoryStream = new MemoryStream();
                var image = new BitmapImage(new Uri(dialog.FileName));
                var encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(image));
                encoder.Save(memoryStream);

                // Create a new ImageEntity object and set its ImageData property to the memory stream buffer
                var imageEntity = new UserViewModel();
                imageEntity.ImageUser = memoryStream.GetBuffer();

            }

            var imageData = File.ReadAllBytes(dialog.FileName);

            using (UserDataContex contex= new UserDataContex())
            {
                
                
                int id=Convert.ToInt32(idtxt.Text);
                var name = nametxt.Text;
                var dateofbirth = datetxt.Text;
                var nic= nictxt.Text;
                var mobile = mobiletxt.Text;
                var password= passtxt.Text;
               
                
                
                if(id!=-1 && name!="" && dateofbirth!="" && nic!= "" && mobile!="" && password!="" ) 
                {
                    contex.Users.Add(new UserViewModel() { Name = name, Date_of_birth = dateofbirth, NIC = nic, Mobile = mobile, Password = password, UserId=id,ImageUser= imageData });
                    contex.SaveChanges();
                }
                else
                {
                    MessageBox.Show("You have to fill all rows");
                }
                
            }
        }

        private void addPatientbtn_Click(object sender, RoutedEventArgs e)
        {
            
            var name = nametxt.Text;
            var dateofbirth = datetxt.Text;
            var nic = nictxt.Text;
            var mobile = mobiletxt.Text;
            var password = passtxt.Text;



            if ( name != "" && dateofbirth != "" && nic != "" && mobile != "" && password != "")
            {
                Adduser();

                MessageBox.Show("successfully added ");
                idtxt.Text = "";
                nametxt.Text = "";
                datetxt.Text = "";
                nictxt.Text = "";
                mobiletxt.Text = "";
                passtxt.Text = "";
            }
            else
            {
                MessageBox.Show("Enter all the details");

            }

            
        }

    }
}
