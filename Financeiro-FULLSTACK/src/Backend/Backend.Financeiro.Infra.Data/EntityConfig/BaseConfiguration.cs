using Backend.Financeiro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Financeiro.Infra.Data.EntityConfig
{
    public class BaseConfiguration : IEntityTypeConfiguration<Base>
    {
        public void Configure(EntityTypeBuilder<Base> builder)
        {
            //builder.Property(b =>b.Id)
            //    .HasColumnName("Id");
                

            builder.Property(c => c.Name)
                .HasColumnType("varchar(150)")
                .HasColumnName("Name");

        }
    }
}
