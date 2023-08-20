using Backend.Financeiro.Domain.Entities.Systems.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.Financeiro.Infra.Data.EntityConfig.Systems.Users
{
    internal class FinanceSystemUserConfiguration : IEntityTypeConfiguration<FinanceSystemUser>
    {
        public void Configure(EntityTypeBuilder<FinanceSystemUser> builder)
        {
            builder.ToTable("UsuarioSistemaFinanceiro");


            //builder.Property(fsu => fsu.SystemId)
            // .HasColumnName("SystemId");

            builder.Property(fsu => fsu.UserEmail)
                .HasColumnType("varchar(150)")
                .HasMaxLength(150)
                .IsRequired();



        }
    }
}
