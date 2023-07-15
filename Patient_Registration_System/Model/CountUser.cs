using Patient_Registration_System.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Registration_System.Model
{
    public class CountUser
    {
        public List<UserViewModel> User { get; set; }

        public static int countUser()
        {
            int count = 0;
            using (UserDataContex context = new UserDataContex())
            {
                var countuser = new CountUser(); // Create a new instance of the Revenue class
                countuser.User = context.Users.ToList();
                if (countuser.User != null)
                {
                    foreach (UserViewModel user in countuser.User)
                    {
                        count++;

                    }
                }

            }


            return count;
        }
    }
}
