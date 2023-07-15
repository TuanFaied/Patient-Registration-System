using Patient_Registration_System.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Registration_System.Model
{
    public class Revenue
    {
        public List<EntryData> User { get; set; }

        public static int countRevenue()
        {
            int count = 0;
            using(UserDataContex context = new UserDataContex())
            {
                var revenue = new Revenue(); // Create a new instance of the Revenue class
                revenue.User = context.entryDatas.ToList();
                if (revenue.User != null)
                {
                    foreach (EntryData user in revenue.User)
                    {
                        count = user.Amount + count;

                    }
                }

            }
            
            
            return count;
        }
    }
}
