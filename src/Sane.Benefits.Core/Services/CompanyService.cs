using System;
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
            throw new NotImplementedException();
        }
    }
}
