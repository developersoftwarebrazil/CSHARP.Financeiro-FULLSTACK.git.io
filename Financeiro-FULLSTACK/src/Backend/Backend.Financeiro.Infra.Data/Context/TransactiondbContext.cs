using Backend.Financeiro.Domain.Entities.Categories;
using Backend.Financeiro.Domain.Entities.Identities.Users;
using Backend.Financeiro.Domain.Entities.Systems;
using Backend.Financeiro.Domain.Entities.Systems.Transactions;
using Backend.Financeiro.Domain.Entities.Systems.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

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
            base.OnModelCreating(builder);
        }
        public string GetConnetioString()
        {
            return "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Finance_Fullstack_2023;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

    }
}
