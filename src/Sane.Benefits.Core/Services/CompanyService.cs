using AutoMapper;
using Sane.Benefits.Core.Interfaces;
using Sane.Benefits.Data;
using Sane.Benefits.DomainModels;

namespace Sane.Benefits.Core.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly BenefitsContext _benefitsContext;

        public CompanyService(BenefitsContext benefitsContext)
        {
            _benefitsContext = benefitsContext;
        }

        public void Add(Company company)
        {
            var companyEntity = Mapper.Map<Data.Entities.Company>(company);
            _benefitsContext.Companies.Add(companyEntity);
            _benefitsContext.SaveChanges();
        }
    }
}
