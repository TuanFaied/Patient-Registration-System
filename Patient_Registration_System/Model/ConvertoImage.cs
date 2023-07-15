using SixLabors.ImageSharp.Memory;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Drawing;
using System.Drawing.Imaging;
using Patient_Registration_System.ViewModel;

namespace Patient_Registration_System.Model
{
    public class ConvertoImage
    {

        public static byte[] ImageToByte(Uri uri)
        {
            BitmapImage bitmap = new BitmapImage(uri);
            byte[] data;

            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(bitmap));

            using (MemoryStream ms = new MemoryStream())
            {
                encoder.Save(ms);
                data = ms.ToArray();
            }

            return data;
        }


    }
}
