using Patient_Registration_System.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Patient_Registration_System.ViewModel
{
    public class UserViewModel
    {
        [Key]
        public int UserId { get; set; }
        
        
        public string Name { get; set; }
        public string Password { get; set; }
        public string Date_of_birth { get; set; }
        public string NIC { get; set; }
        public string Mobile { get; set; }
         public byte[] ImageUser { get; set; }
       


        public List<EntryData>? entryDatas { get; set; }

    }
}