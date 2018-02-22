using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstApp.Models;

namespace MyFirstAppTests
{
    [TestClass]
    public class UserDetailsTests
    {
        [TestMethod]
        public void Should_Populate_Message_When_Greeted()
        {
            //Arrange
            var sut = new UserDetails();
            sut.FirstName = "Magesh";
            sut.LastName = "Kuppan";
            var expectedResult = $"Hi {sut.FirstName} {sut.LastName}, Have a nice day!";

            //Act
            sut.Greet();

            //Assert
            Assert.AreEqual(expectedResult, sut.Message);
        }
    }
}
