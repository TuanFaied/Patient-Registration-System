using FluentAssertions;
using Patient_Registration_System.Model;
using Patient_Registration_System.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class RevenueTest
    {
        [Fact]
        public void CountRevenue_WhenNoEntries_ReturnsZero()
        {
            // Arrange
            var expectedCount = 0;
            var context = new UserDataContex();
          //  context.Database.EnsureDeleted();
           // context.Database.EnsureCreated();
            // Act
            var actualCount = Revenue.countRevenue();

            // Assert
            actualCount.Should().Be(expectedCount);
            // Cleanup
            context.Admins.RemoveRange(context.Admins);
        }

        [Fact]
        public void CountRevenue_WhenOneEntry_ReturnsAmount()
        {
            // Arrange
            var expectedCount = 100;
            var context = new UserDataContex();
             context.Database.EnsureDeleted();
              context.Database.EnsureCreated();
            var u = new UserViewModel();
            u.UserId = 01;
            u.Name = "Test";
            u.Password = "password";
            u.Date_of_birth = "03.02.2122";
            u.NIC = "125132";
            u.Mobile = "154211";
            u.ImageUser = ConvertoImage.ImageToByte(new Uri("E:\\semester 3\\Programming project\\Patient_Registration_System\\Patient_Registration_System\\Images\\1.png", UriKind.Relative));


            context.Users.Add(u);

            context.entryDatas.Add(new EntryData { Amount = 100, Date="03.02.2020", Discribtion="dsfsdf", Madicine="sdfs", No=1, PatientId=01 });
            context.SaveChanges();

            // Act
            var actualCount = Revenue.countRevenue();

            // Assert
            actualCount.Should().Be(expectedCount);

            // Cleanup
            context.Admins.RemoveRange(context.Admins);
            context.entryDatas.RemoveRange(context.entryDatas);
            context.Users.RemoveRange(context.Users);
            context.SaveChanges();
        }

        [Fact]
        public void CountRevenue_WhenMultipleEntries_ReturnsSumOfAmounts()
        {
            // Arrange
            var expectedCount = 300;
            var context = new UserDataContex();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            var u1 = new UserViewModel();
            u1.UserId = 100;
            u1.Name = "Test";
            u1.Password = "password";
            u1.Date_of_birth = "03.02.2122";
            u1.NIC = "125132";
            u1.Mobile = "154211";
            u1.ImageUser = ConvertoImage.ImageToByte(new Uri("E:\\semester 3\\Programming project\\Patient_Registration_System\\Patient_Registration_System\\Images\\1.png", UriKind.Relative));

            var u2 = new UserViewModel();
            u2.UserId = 101;
            u2.Name = "Test2";
            u2.Password = "password2";
            u2.Date_of_birth = "02.01.2445";
            u2.NIC = "2527575";
            u2.Mobile = "04272";
            u2.ImageUser = ConvertoImage.ImageToByte(new Uri("E:\\semester 3\\Programming project\\Patient_Registration_System\\Patient_Registration_System\\Images\\1.png", UriKind.Relative));

            var u3 = new UserViewModel();
            u3.UserId = 102;
            u3.Name = "Test3";
            u3.Password = "password3";
            u3.Date_of_birth = "02.24.5244";
            u3.NIC = "752742";
            u3.Mobile = "042742";
            u3.ImageUser = ConvertoImage.ImageToByte(new Uri("E:\\semester 3\\Programming project\\Patient_Registration_System\\Patient_Registration_System\\Images\\1.png", UriKind.Relative));
            context.Users.Add(u1);
            context.Users.Add(u2);
            context.Users.Add(u3);
            context.entryDatas.Add(new EntryData { Amount = 100, Date = "03.02.2020", Discribtion = "dsfsdf", Madicine = "sdfs", No = 1, PatientId = 100 });
            context.entryDatas.Add(new EntryData { Amount = 150, Date = "15.02.2020", Discribtion = "dfsdfdfg", Madicine = "qeqwe", No = 2, PatientId = 101 });
            context.entryDatas.Add(new EntryData { Amount = 50, Date = "12.02.2020", Discribtion = "retr", Madicine = "cvbc", No = 3, PatientId = 102 });
            context.SaveChanges();

            // Act
            var actualCount = Revenue.countRevenue();

            // Assert
            actualCount.Should().Be(expectedCount);

            // Cleanup
            context.Admins.RemoveRange(context.Admins);
            context.entryDatas.RemoveRange(context.entryDatas);
            context.Users.RemoveRange(context.Users);
            context.SaveChanges();
        }

        //    [Fact]
        //    public void CountRevenue_WhenNullEntries_ReturnsZero()
        //    {
        //        // Arrange
        //        var expectedCount = 0;
        //        var revenue = new Revenue();

        //        revenue.User = null;

        //        // Act
        //        var actualCount = Revenue.countRevenue();

        //        // Assert
        //        actualCount.Should().Be(expectedCount);
        //    }
    }
}
