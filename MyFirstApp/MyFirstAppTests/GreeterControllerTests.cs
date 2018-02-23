using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstApp.Controllers;
using MyFirstApp.Models;
using MyFirstApp.Services;
using Moq;

namespace MyFirstAppTests
{
    /*
    class FakeDateTimeClassForMorning : IDateTimeService{
        public DateTime GetCurrent(){
            return new DateTime(2018, 02, 23, 9, 0, 0);
        }
    }

    class FakeDateTimeClassForEvening : IDateTimeService
    {
        public DateTime GetCurrent()
        {
            return new DateTime(2018, 02, 23, 17, 0, 0);
        }
    }
    */

    [TestClass]
    public class GreeterControllerTests
    {
        /*
        [TestMethod]
        public void Should_Return_Default_View_For_Greet()
        {
            //Arrange
            var greetController = new GreeterController();

            //Act
            var result = greetController.Greet();

            //Assert
            Assert.IsNull(result.ViewName);

        }

        [TestMethod]
        public void Should_Have_UserDetails_In_ViewBag()
        {
            //Arrange
            var greetController = new GreeterController();

            //Act
            var result = greetController.Greet();

            //Assert
            Assert.IsNotNull(greetController.ViewBag.userDetails);
            Assert.IsInstanceOfType(greetController.ViewBag.userDetails, typeof(UserDetails));

        }

        [TestMethod]
        public void Should_Display_Message_From_UserDetails()
        {
            //Arrange
            var greetController = new GreeterController();
            var dummyUserDetails = new UserDetails() { FirstName = "Dummy FN", LastName = "Dummy LN" };
            //Act
            var result = greetController.Greet(dummyUserDetails);

            //Assert
            var resultMessage = (string)result.ViewData["Message"];
            Assert.AreEqual(dummyUserDetails.Message, resultMessage);

        }
        */

        [TestMethod]
        public void Should_Render_Evening_Message_View()
        {
            //Arrange
            //var fakeEveningDateTimeService = new FakeDateTimeClassForEvening();
            var mock = new Moq.Mock<IDateTimeService>();
            mock.Setup(s => s.GetCurrent()).Returns(new DateTime(2018, 02, 23, 17, 0, 0));
            var greetController = new GreeterController(mock.Object);

            var dummyUserDetails = new UserDetails() { FirstName = "Dummy FN", LastName = "Dummy LN" };
            //Act
            var result = greetController.Greet(dummyUserDetails);

            //Assert
            Assert.AreEqual("EveningMessage", result.ViewName);

        }

        [TestMethod]
        public void Should_Render_Morning_Message_View()
        {
            //Arrange
            /*
            var fakeMorningDateTimeService = new FakeDateTimeClassForMorning();
            var greetController = new GreeterController(fakeMorningDateTimeService);
            */
            var mock = new Moq.Mock<IDateTimeService>();
            mock.Setup(s => s.GetCurrent()).Returns(new DateTime(2018, 02, 23, 9, 0, 0));
            var greetController = new GreeterController(mock.Object);

            var dummyUserDetails = new UserDetails() { FirstName = "Dummy FN", LastName = "Dummy LN" };
            //Act
            var result = greetController.Greet(dummyUserDetails);

            //Assert
            Assert.AreEqual("MorningMessage", result.ViewName);

        }
    }
}
