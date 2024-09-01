using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpnInnovation.Domain.Entities;
using System.Runtime.CompilerServices;
using RpnInnovation.Infrastructure.Persistence.SchemaDefinition;

namespace RpnInnovation.Infrastructure.Persistence
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions options)
            :base(options) { }
        DbSet<Account> Account { get; set; }
        DbSet<Transaction> Transactions { get; set; }
        DbSet<CustomerAccount> CustomerAccounts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TransactionSchemaDefinition).Assembly);

            base.OnModelCreating(modelBuilder);
        }

    }
}
