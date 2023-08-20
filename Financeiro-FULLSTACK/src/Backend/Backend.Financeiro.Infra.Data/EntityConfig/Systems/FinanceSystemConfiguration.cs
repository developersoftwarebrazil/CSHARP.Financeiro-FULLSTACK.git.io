using Backend.Financeiro.Domain.Entities.Systems;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Financeiro.Infra.Data.EntityConfig.Systems
{
    public class FinanceSystemConfiguration : IEntityTypeConfiguration<FinanceSystem>
    {
        public void Configure(EntityTypeBuilder<FinanceSystem> builder)
        {
            builder.ToTable("SistemaFinanceiro");
        }
    }
}
