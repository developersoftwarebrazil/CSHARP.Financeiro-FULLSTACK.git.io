using Backend.Financeiro.Domain.Entities.Systems;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
