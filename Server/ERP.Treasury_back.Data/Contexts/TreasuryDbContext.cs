using ERP.Treasury.Common.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Treasury.Data.Contexts
{
    public class TreasuryDbContext : DbContext
    {

        public TreasuryDbContext() : base("data source=(localdb)\\MSSQLLocalDB;initial catalog=Treasury;Integrated Security=SSPI;MultipleActiveResultSets=True;App=EntityFramework") { }
        public TreasuryDbContext(string connectionString) : base(DbProviderFactories.GetFactory("System.Data.SqlClient").CreateConnection(), true)
        {
            Database.Connection.ConnectionString = connectionString;
            Configuration.ProxyCreationEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<TreasuryDbContext>(null);
            modelBuilder.HasDefaultSchema("Accounting");
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Document_types> Document_types { get; set; }
        public virtual DbSet<Tax> Taxes { get; set; }
    }
}
