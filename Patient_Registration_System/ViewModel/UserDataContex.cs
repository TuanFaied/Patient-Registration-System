using Microsoft.EntityFrameworkCore;
using Patient_Registration_System.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Drawing;
using System.Drawing.Imaging;
using SixLabors.ImageSharp;
using System.Security.Policy;

namespace Patient_Registration_System.ViewModel
{
    public class UserDataContex : DbContext
    {
        public UserDataContex()
        {
        }

        public UserDataContex(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<UserViewModel> Users { get; set; }
        public DbSet<AdminViewModel> Admins { get; set; }
        public DbSet<EntryData> entryDatas { get; set; }

        public DbSet<SaveUser> saveUsers { get; set; }

      //  byte[] imagebyte = ConvertoImage.ImageToByte(new Uri(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images/1.png")));
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminViewModel>().HasKey(x => x.Id);
            modelBuilder.Entity<AdminViewModel>().Property(x=>x.A_Password).IsRequired().HasMaxLength(255);
            modelBuilder.Entity<AdminViewModel>().Property(x=>x.A_Name).IsRequired().HasMaxLength(255);
            modelBuilder.Entity<AdminViewModel>().Property(x=>x.ImageAdmin).IsRequired().HasMaxLength(255);
            modelBuilder.Entity<AdminViewModel>().HasData(

                    new AdminViewModel
                    {
                        A_Name = "Admin",
                        A_Password = "admin123",
                        Id = 1,
                        ImageAdmin = ConvertoImage.ImageToByte(new Uri("E:\\semester 3\\Programming project\\Patient_Registration_System\\Patient_Registration_System\\Images\\1.png", UriKind.Relative))
                    }
                );
            modelBuilder.Entity<SaveUser>().HasKey(s => s.SaveId);
            modelBuilder.Entity<SaveUser>().Property(s=> s._userName).IsRequired().HasMaxLength(255);
            modelBuilder.Entity<SaveUser>().HasData(
                new SaveUser { SaveId= 1 , _userName="save"}
                );
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if(!options.IsConfigured) {
                options.UseSqlite("Data Source = DataFile.db");
            }
           

        }   
        
        
        

    }

}
