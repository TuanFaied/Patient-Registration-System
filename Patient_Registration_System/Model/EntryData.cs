using Patient_Registration_System.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patient_Registration_System.Model;

namespace Patient_Registration_System.Model
{
    public class EntryData
    {
        [Key]
        public int No { get; set; }

        public string Date { get; set; }
        public string Madicine { get; set; }
        public string Discribtion { get; set; }
        public int Amount { get; set; }

        

        public int PatientId { get; set; }
        [ForeignKey("PatientId")]
        public UserViewModel UserViewmodel { get; set; }

        //public int UserViewmodelId { get; internal set; }
        
    }
}
