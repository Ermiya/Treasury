using ERP.Treasury_back.Common.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Treasury_back.Data.Contexts
{
    public class PayrollDbContext : DbContext
    {

        public PayrollDbContext() : base("name=Default") { }
        public PayrollDbContext(string connectionString) : base(DbProviderFactories.GetFactory("System.Data.SqlClient").CreateConnection(), true)
        {
            Database.Connection.ConnectionString = connectionString;
            Configuration.ProxyCreationEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<PayrollDbContext>(null);
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Document_types> Document_types { get; set; }
    }
}
