using FluentAssertions;
using Patient_Registration_System.Model;
using Patient_Registration_System.ViewModel;
using System.Collections.Generic;

namespace UnitTest
{
    public class CountUserTests
    {
        [Fact]
        public void CountUser_WhenNoUsers_ReturnsZero()
        {
            // Arrange
            var expectedCount = 0;
            var context = new UserDataContex();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            // Act

            var actualCount = CountUser.countUser();

            // Assert
            actualCount.Should().Be(expectedCount);

            context.Admins.RemoveRange(context.Admins);
        }
        [Fact]
        public void CountUser_WhenOneUser_ReturnsOne()
        {
            // Arrange
            var expectedCount = 1;
            var context = new UserDataContex();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            var u = new UserViewModel();
            u.UserId = 01; 
            u.Name = "Test";
            u.Password= "password";
            u.Date_of_birth = "03.02.2122";
            u.NIC = "125132";
            u.Mobile = "154211";
            u.ImageUser = ConvertoImage.ImageToByte(new Uri("E:\\semester 3\\Programming project\\Patient_Registration_System\\Patient_Registration_System\\Images\\1.png", UriKind.Relative));


            context.Users.Add(u);
            context.SaveChanges();

            // Act
            var actualCount = CountUser.countUser();

            // Assert
            actualCount.Should().Be(expectedCount);

            // Cleanup
            context.Admins.RemoveRange(context.Admins);
            context.Users.RemoveRange(context.Users);
            context.SaveChanges();
        }

        [Fact]
        public void CountUser_WhenMultipleUsers_ReturnsCorrectCount()
        {
            // Arrange
            var expectedCount = 3;
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

            var u2 = new UserViewModel();
            u2.UserId = 02;
            u2.Name = "Test2";
            u2.Password = "password2";
            u2.Date_of_birth = "02.01.2445";
            u2.NIC = "2527575";
            u2.Mobile = "04272";
            u2.ImageUser = ConvertoImage.ImageToByte(new Uri("E:\\semester 3\\Programming project\\Patient_Registration_System\\Patient_Registration_System\\Images\\1.png", UriKind.Relative));

            var u3 = new UserViewModel();
            u3.UserId = 03;
            u3.Name = "Test3";
            u3.Password = "password3";
            u3.Date_of_birth = "02.24.5244";
            u3.NIC = "752742";
            u3.Mobile = "042742";
            u3.ImageUser = ConvertoImage.ImageToByte(new Uri("E:\\semester 3\\Programming project\\Patient_Registration_System\\Patient_Registration_System\\Images\\1.png", UriKind.Relative));
            context.Users.Add(u);
            context.Users.Add(u2);
            context.Users.Add(u3);
            context.SaveChanges();

            // Act
            var actualCount = CountUser.countUser();

            // Assert
            actualCount.Should().Be(expectedCount);

            // Cleanup
            context.Admins.RemoveRange(context.Admins);
            context.Users.RemoveRange(context.Users);
            context.SaveChanges();
        }

        //[Fact]
        //public void CountUser_WhenNullUsers_ReturnsZero()
        //{
        //    // Arrange
        //    var expectedCount = 0;
        //    var context = new UserDataContex();
        //    context.Database.EnsureDeleted();
        //    context.Database.EnsureCreated();
        //    var countuser = new CountUser();
        //    countuser.User = null;

        //    // Act
        //    var actualCount = CountUser.countUser();

        //    // Assert
        //    actualCount.Should().Be(expectedCount);
        //}
    }
}