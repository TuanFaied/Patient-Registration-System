using Microsoft.Win32;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Patient_Registration_System.View
{
    /// <summary>
    /// Interaction logic for UserSettingView.xaml
    /// </summary>
    public partial class UserSettingView : UserControl
    {
        private string _username;
        public UserSettingView()
        {
            InitializeComponent();
        }
        public UserSettingView(string name)
        {
            InitializeComponent();
            DataContext = new UserSettingViewModel(name);
            _username = name;
          //  string name = App.ViewModel.ValueToTransfer;

            //using (UserDataContex context = new UserDataContex())
            //{
            //     UserViewModel currentUser = context.Users.FirstOrDefault(x => x.Name ==_username);
            //   // var imagedata = context.Users.FirstOrDefault(x => x.Name == name)?.ImageUser;
            //    var imagedata = currentUser.ImageUser;

            //    changeImg.Source = currentUser.ImageUser;
            //}
        }
        
        //   public string ReceivedValue { get; set; }
        public void SaveChange()
        {
            using (UserDataContex context = new UserDataContex())
            {
                UserViewModel currentuser = context.Users.FirstOrDefault(x => x.Name == olduserNametxt.Text) ;
                var newadminname = newuserNametxt.Text;
                var oldadminname = olduserNametxt.Text;
                var oldadminpassword = userOldpasswordxt.Text;
                var newadminpassword = userNewpasswordxt.Text;
                if (newadminname != "" && newadminpassword != "" && oldadminname == currentuser.Name && oldadminpassword == currentuser.Password)
                {
                    

                    UserViewModel admin = context.Users.FirstOrDefault(x => x.Name == oldadminname);
                   if(admin != null) {
                        admin.Name = newadminname;
                        admin.Password = newadminpassword;

                        context.SaveChanges();
                    }
                   else
                    {
                        MessageBox.Show("Old User Name or Password is incorrect");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Old user name or password is wrong!!!");
                }

            }
        }
        private void saveChanegesbtn_Click1(object sender, RoutedEventArgs e)
        {
            SaveChange();
            MessageBox.Show("Changed");
            newuserNametxt.Text = "";
            olduserNametxt.Text = "";
             userOldpasswordxt.Text="";
             userNewpasswordxt.Text="";
        }

        private void changeimgBtn1_Click(object sender, RoutedEventArgs e)
        {
            var newadminname = newuserNametxt.Text;
            var oldadminname = olduserNametxt.Text;
            var oldadminpassword = userOldpasswordxt.Text;
            var newadminpassword = userNewpasswordxt.Text;
            if(oldadminname!="")
            {
                OpenFileDialog dialog1 = new OpenFileDialog();
                dialog1.Filter = "Image files | *.bmp; *.png; *.jpg";
                dialog1.FilterIndex = 1;
                if (dialog1.ShowDialog() == true)
                {

                    // Load the image data into a memory stream
                    var memoryStream = new MemoryStream();
                    var image = new BitmapImage(new Uri(dialog1.FileName));
                    var encoder = new JpegBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create(image));
                    encoder.Save(memoryStream);

                    // Create a new ImageEntity object and set its ImageData property to the memory stream buffer
                    var imageEntity = new UserViewModel();
                    imageEntity.ImageUser = memoryStream.GetBuffer();

                }

                var imageData = File.ReadAllBytes(dialog1.FileName);

                //var imageModel = new AdminViewModel { ImageAdmin = imageData };
                using (var db = new UserDataContex())
                {
                    var imagedata = db.Users.FirstOrDefault(x => x.Name == oldadminname);
                    imagedata.ImageUser = imageData;
                    //db.Admins.Add(imageModel);
                    db.SaveChanges();
                    MessageBox.Show("Image is updaated.Plese relogin. The Profile will change ");
                }

            }
            else
            {
                MessageBox.Show("You have to enter Old User Name");

            }
            
            
        }
    }
}
//var image = new BitmapImage();
//using (var stream = new MemoryStream(imagedata))
//{
//    image.BeginInit();
//    image.CacheOption = BitmapCacheOption.OnLoad;
//    image.StreamSource = stream;
//    image.EndInit();
//}
//   changeImg.Source = image; changeImg.Visibility = Visibility.Visible;