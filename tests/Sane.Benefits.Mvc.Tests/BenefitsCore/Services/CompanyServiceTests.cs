using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Sane.Benefits.Core.Data;
using Sane.Benefits.Core.Services;
using Sane.Benefits.Models;

namespace Sane.Benefits.Mvc.UnitTests.BenefitsCore.Services
{
    [TestClass]
    public class CompanyServiceTests
    {
        [TestMethod]
        public void AddCompany()
        {
            //Arrange
            var mockCompany = new Mock<DbSet<Company>>();
            var mockBenefitsContext = new Mock<BenefitsContext>();
            mockBenefitsContext.Setup(b => b.Companies).Returns(mockCompany.Object);
            var expectedCompany = new Company
            {
                DoingBusinessAs = "Test Company",
                LegalName = "Test Company"
            };
            var companyService = new CompanyService(mockBenefitsContext.Object);

            //Act
            companyService.Add(expectedCompany);

            //Assert

        }
    }
}
