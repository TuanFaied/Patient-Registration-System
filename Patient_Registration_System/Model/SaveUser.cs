using Patient_Registration_System.View;
using Patient_Registration_System.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Registration_System.Model
{
  public  class SaveUser 
    {
        [Key]
        public int SaveId { get; set; }
        public string _userName { get; set; }   
      //  public string _password { get; set; }

        //public int UserId { get; set; }
        //[ForeignKey("UserId")]
        //public UserViewModel UserViewmodel { get; set; }


    }
}
