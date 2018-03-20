using System.Net;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Sane.Benefits.Core.Interfaces;
using Sane.Benefits.DomainModels;
using Sane.Benefits.DomainModels.Enums;
using Sane.Benefits.Mvc.Controllers;
using Sane.Benefits.Mvc.ViewModels;

namespace Sane.Benefits.Mvc.UnitTests.BenefitsMvc.ControllerTests
{
    [TestClass]
    public class RegisterControllerTests
    {
        [TestMethod]
        public void RegisterNewUser()
        {
            //Arrange
            var newUser = new NewUserViewModel
            {
                FullName = "Narendiran Dorairaj",
                Email = "narendiran@gmail.com",
                CompanyName = "The Little Kingdom",
                PhoneNumber = "1234567890",
                Title = "Senior HR Specialist",
                NumberOfEmployees = NumberOfEmployees.Xs
            };
            var mockCompanyServices = new Mock<ICompanyService>();
            var mockUserServices = new Mock<IUserService>();
            mockCompanyServices.Setup(c => c.Add(It.IsAny<Company>()));
            mockUserServices.Setup(u => u.Add(It.IsAny<User>()));
            var registerController = new RegisterController(mockCompanyServices.Object, mockUserServices.Object);

            //Act
            var result = (HttpStatusCodeResult)registerController.AddUser(newUser);

            //Assert
            Assert.AreEqual(HttpStatusCode.Created, (HttpStatusCode)result.StatusCode);
            mockCompanyServices.Verify(cs => cs.Add(It.IsAny<Company>()), Times.Once);
            mockUserServices.Verify(us => us.Add(It.IsAny<User>()), Times.Once);
        }
    }
}
