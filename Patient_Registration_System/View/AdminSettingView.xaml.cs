using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
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
using System.Security.Principal;
using Microsoft.Win32;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Processing;
using System.Xml.Linq;

namespace Patient_Registration_System.View
{
    /// <summary>
    /// Interaction logic for AdminSettingView.xaml
    /// </summary>
    public partial class AdminSettingView : UserControl
    {
        public AdminSettingView()
        {
            InitializeComponent();
            
            using (UserDataContex context = new UserDataContex())
            {
                AdminViewModel currentUser = context.Admins.FirstOrDefault(x => x.Id == 1);
               
                var imagedata = currentUser.ImageAdmin;
                var image = new BitmapImage();
                using (var stream = new MemoryStream(imagedata))
                {
                    image.BeginInit();
                    image.CacheOption = BitmapCacheOption.OnLoad;
                    image.StreamSource = stream;
                    image.EndInit();
                }

                changeimg.Source = image;

            }

        }

        public void SaveChange()
        {
            using(UserDataContex context= new UserDataContex())
            {
                AdminViewModel currentUser = context.Admins.FirstOrDefault(x => x.Id == 1);
                var newadminname=newuserNametxt.Text;
                var oldadminname= olduserNametxt.Text;
                var oldadminpassword=userOldpasswordxt.Text;
                var newadminpassword = userNewpasswordxt.Text;
                if (newadminname!=null && newadminpassword!=null && oldadminname == currentUser.A_Name && oldadminpassword == currentUser.A_Password)
                {
                    //bool adminfound = context.Admins.Any(admin => admin.A_Name == oldadminname && admin.A_Password==oldadminpassword );  
                    //if (adminfound)
                    //{
                    //    AdminViewModel admin= new AdminViewModel();
                    //    admin.A_Name = newadminname;
                    //    admin.A_Password = newadminpassword;

                    //}
                    
                    AdminViewModel admin = context.Admins.Find(1);
                    admin.A_Name= newadminname;
                    admin.A_Password= newadminpassword;

                    context.SaveChanges();
                }

            }
        }
        private void saveChanegesbtn_Click(object sender, RoutedEventArgs e)
        {
            using (UserDataContex context = new UserDataContex())
            {
                AdminViewModel currentUser = context.Admins.FirstOrDefault(x => x.Id == 1);
                var newadminname = newuserNametxt.Text;
                var oldadminname = olduserNametxt.Text;
                var oldadminpassword = userOldpasswordxt.Text;
                var newadminpassword = userNewpasswordxt.Text;
                if (newadminname != null && newadminpassword != null && oldadminname == currentUser.A_Name && oldadminpassword == currentUser.A_Password)
                {
                    SaveChange();
                    MessageBox.Show("Changed");
                    newuserNametxt.Text = "";
                    olduserNametxt.Text = "";
                    userOldpasswordxt.Text = "";
                    userNewpasswordxt.Text = "";
                }
                else
                {
                    MessageBox.Show("Old user name or password is wrong!!!");
                }

                
            }
                
        }

        private void changeimgBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog= new OpenFileDialog();
            dialog.Filter= "Image files | *.bmp; *.png; *.jpg";
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
                    var imageEntity = new AdminViewModel();
                    imageEntity.ImageAdmin = memoryStream.GetBuffer();
                
            }
            
            var imageData = File.ReadAllBytes(dialog.FileName);
            
            //var imageModel = new AdminViewModel { ImageAdmin = imageData };
            using (var db=new UserDataContex())
            {
                var imagedata = db.Admins.Find(1);
                imagedata.ImageAdmin = imageData;
                //db.Admins.Add(imageModel);
                db.SaveChanges();
                MessageBox.Show("up");
            }
        }
    }
}
