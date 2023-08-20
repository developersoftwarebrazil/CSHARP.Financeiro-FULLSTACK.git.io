using Backend.Financeiro.Domain.Entities.Systems.Transactions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
