using Backend.Financeiro.Domain.Entities.Systems.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
