using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RpnInnovation.Domain.Entities;

namespace RpnInnovation.Infrastructure.Persistence.SchemaDefinition
{

    public class AccountSchemaDefinition : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            // declare as pry key
            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.AccountNumber);
            builder.Property(x => x.AccountNumber)
                .HasMaxLength(10);

            builder.Property(x => x.Balance)
                .HasPrecision(18, 2);
            builder.Property(x => x.LedgerBalance)
                .HasPrecision(18, 2);
        }
    }
}
