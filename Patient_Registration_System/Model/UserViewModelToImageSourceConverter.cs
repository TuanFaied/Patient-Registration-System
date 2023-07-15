using Patient_Registration_System.ViewModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;


namespace Patient_Registration_System.Model
{
    public class UserViewModelToImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            CompositeViewModel userViewModel = value as CompositeViewModel;
            if (userViewModel != null && userViewModel.userViewModel.ImageUser != null)
            {
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.StreamSource = new System.IO.MemoryStream(userViewModel.userViewModel.ImageUser);
                image.EndInit();
                return image;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
