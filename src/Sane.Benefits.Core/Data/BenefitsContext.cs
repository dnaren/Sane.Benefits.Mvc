using System.Data.Entity;
using Sane.Benefits.Models;

namespace Sane.Benefits.Core.Data
{
    public class BenefitsContext : DbContext
    {
        public virtual DbSet<Company> Companies { get; set; }
    }
}
