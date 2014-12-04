using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AjourNet.Domain.Concrete
{
    public class AjourNetContext : DbContext
    {

        public AjourNetContext()
            : base("AjourNetContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}