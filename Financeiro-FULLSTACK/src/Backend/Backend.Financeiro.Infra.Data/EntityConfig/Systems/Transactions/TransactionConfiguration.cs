using Backend.Financeiro.Domain.Entities.Systems.Transactions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.Financeiro.Infra.Data.EntityConfig.Systems.Transactions
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transacao");

            builder.Property(t => t.Value)
                .HasColumnType("decimal(18, 2)");

        }
    }
}
