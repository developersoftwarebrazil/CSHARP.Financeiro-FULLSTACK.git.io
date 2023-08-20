using Backend.Financeiro.Domain.Entities.Categories;
using Backend.Financeiro.Domain.Entities.Identities.Users;
using Backend.Financeiro.Domain.Entities.Systems;
using Backend.Financeiro.Domain.Entities.Systems.Transactions;
using Backend.Financeiro.Domain.Entities.Systems.Users;
using Backend.Financeiro.Infra.Data.EntityConfig;
using Backend.Financeiro.Infra.Data.EntityConfig.Categories;
using Backend.Financeiro.Infra.Data.EntityConfig.Systems;
using Backend.Financeiro.Infra.Data.EntityConfig.Systems.Transactions;
using Backend.Financeiro.Infra.Data.EntityConfig.Systems.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Backend.Financeiro.Infra.Data.Context
{
    public class TransactiondbContext : IdentityDbContext<ApplicationUser>
    {
        public TransactiondbContext(DbContextOptions options) : base(options) { }

        public DbSet<ApplicationUser> ApplicationUser { set; get; }
        public DbSet<Category> Categories { set; get; }
        public DbSet<FinanceSystem> FinanceSystem { set; get; }
        public DbSet<FinanceSystemUser> FinanceSystemUsers { set; get; }
        public DbSet<Transaction> Transactions { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(GetConnetioString());
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>().ToTable("AspNetUsers").HasKey(t => t.Id);

            #region EntityCustomize

            builder.Entity<ApplicationUser>(b =>
            {
                b.ToTable("Identity_Users").HasKey(b => b.Id);
            });

            builder.Entity<IdentityUserClaim<string>>(b =>
            {
                b.ToTable("Identity_UsuarioDeclaracao");
            });

            builder.Entity<IdentityUserLogin<string>>(b =>
            {
                b.ToTable("Identity_UsuarioLogins");
            });

            builder.Entity<IdentityUserToken<string>>(b =>
            {
                b.ToTable("Identity_UsuarioTokens");
            });

            builder.Entity<IdentityRole>(b =>
            {
                b.ToTable("Identity_Funcao");
            });

            builder.Entity<IdentityRoleClaim<string>>(b =>
            {
                b.ToTable("Identity_FuncaoDeclaracao");
            });

            builder.Entity<IdentityUserRole<string>>(b =>
            {
                b.ToTable("Identity_UsuarioFuncao");
            });
            #endregion

            //builder.ApplyConfiguration(new BaseConfiguration());
            builder.ApplyConfiguration(new FinanceSystemConfiguration());
            builder.ApplyConfiguration(new FinanceSystemUserConfiguration());
            builder.ApplyConfiguration(new TransactionConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());

            base.OnModelCreating(builder);


        }
        public string GetConnetioString()
        {
            return "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Finance_Fullstack_2023;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

    }
}
