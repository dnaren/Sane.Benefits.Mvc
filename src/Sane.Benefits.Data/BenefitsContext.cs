using System.Data.Entity;
using Sane.Benefits.Data.Entities;

namespace Sane.Benefits.Data
{
    public class BenefitsContext : DbContext
    {
        public virtual DbSet<Company> Companies { get; set; }
    }
}
