using System.Net;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sane.Benefits.Models.Enums;
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
            var registerController = new RegisterController();

            //Act
            var result = (HttpStatusCodeResult)registerController.AddUser(newUser);

            //Assert
            Assert.AreEqual(HttpStatusCode.Created, (HttpStatusCode)result.StatusCode);
        }
    }
}
