using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Patient_Registration_System.ViewModel
{
    public class AdminViewModel
    {
        [Key]
        public int Id { get; set; }
        public string A_Name { get; set; }
        public string A_Password { get; set; }

        public byte[] ImageAdmin { get; set; }

        
    }
}
