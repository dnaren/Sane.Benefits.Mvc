using System.Data.Entity;
using Sane.Benefits.Infrastructure.Data;
using Sane.Benefits.Models;

namespace Sane.Benefits.Mvc.UnitTests.Mocks.InfrastructureData
{
    public class FakeBenefitsContext : IBenefitsContext
    {
        public FakeBenefitsContext()
        {
            Companies = new FakeCompaniesSet();
        }

        public IDbSet<Company> Companies { get; }
    }
}
