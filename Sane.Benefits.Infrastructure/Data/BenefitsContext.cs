using System.Data.Entity;
using Sane.Benefits.Models;

namespace Sane.Benefits.Infrastructure.Data
{
    public interface IBenefitsContext
    {
        IDbSet<Company> Companies { get; set; }
    }

    public class BenefitsContext : DbContext, IBenefitsContext
    {
        public IDbSet<Company> Companies { get; set; }
    }
}
