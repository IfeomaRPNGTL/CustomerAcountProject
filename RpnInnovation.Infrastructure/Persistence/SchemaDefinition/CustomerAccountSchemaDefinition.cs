using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RpnInnovation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnInnovation.Infrastructure.Persistence.SchemaDefinition
{
    public class CustomerAccountSchemaDefinition
    {
        public void Configure(EntityTypeBuilder<CustomerAccount> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.FirstName)
                .HasMaxLength(240);

            builder.Property(x => x.LastName)
                .HasMaxLength(240);

            builder.HasIndex(x => x.Email).IsUnique();
            builder.Property(x => x.Email)
                .HasMaxLength(256);

            builder.Property(x => x.Phone)
                .HasMaxLength(15);

            builder.Property(x => x.Country);

            builder.Property(x => x.State);

            builder.Property(x => x.Bvn)
                .HasMaxLength(11);
            builder.Property(x => x.CreatedBy)
            .HasMaxLength(250);
            builder.Property(x => x.UpdatedBy)
            .HasMaxLength(250);
        }
    }
}
