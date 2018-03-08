using Sane.Benefits.Core.Data;
using Sane.Benefits.Core.Interfaces;
using Sane.Benefits.Models;

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
            _benefitsContext.Companies.Add(company);
            _benefitsContext.SaveChanges();
        }
    }
}
