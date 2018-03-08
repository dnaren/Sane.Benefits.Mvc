using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Sane.Benefits.Core.Services;
using Sane.Benefits.Data;
using Sane.Benefits.DomainModels;

namespace Sane.Benefits.Mvc.UnitTests.BenefitsCore.Services
{
    [TestClass]
    public class CompanyServiceTests
    {
        [TestMethod]
        public void AddCompany()
        {
            //Arrange
            var companyToAdd = new Company();
            var mockCompanySet = new Mock<DbSet<Data.Entities.Company>>();
            var mockBenefitsContext = new Mock<BenefitsContext>();
            mockBenefitsContext
                .Setup(b => b.Companies).Returns(mockCompanySet.Object);
            
            var companyService = new CompanyService(mockBenefitsContext.Object);

            //Act
            companyService.Add(companyToAdd);

            //Assert
            mockBenefitsContext.Verify(c => c.SaveChanges(), Times.Once);
        }
    }
}
