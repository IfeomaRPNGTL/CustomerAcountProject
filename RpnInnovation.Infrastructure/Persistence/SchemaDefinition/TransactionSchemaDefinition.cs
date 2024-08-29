using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RpnInnovation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnInnovation.Infrastructure.Persistence.SchemaDefinition
{
    public class TransactionSchemaDefinition : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            // declare as pry key
            builder.HasKey(x => x.Id);

            // helps for faster search 
            builder.HasIndex(x => x.AccountNumber);
            builder.Property(x => x.AccountNumber)
                .HasMaxLength(10);

            builder.Property(x => x.Amount)
                .HasPrecision(18, 2);
            builder.Property(x => x.Charge)
               .HasPrecision(18, 2);
            builder.Property(x => x.NetAmount)
              .HasPrecision(18, 2);
            builder.Property(x => x.CreatedBy)
              .HasMaxLength(250);
            builder.Property(x => x.UpdatedBy)
            .HasMaxLength(250);
        }
    }
}
