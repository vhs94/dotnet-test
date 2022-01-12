using Dotnet.Api.Domain.Entity;
using Dotnet.Api.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Dotnet.Api.Infra.Data.Context
{
    public class SqlContext : DbContext
    {
        public DbSet<Produto> Produto { get; set; }
        public DbSet<ProdutoCosif> ProdutoCosif { get; set; }
        public DbSet<MovimentoManual> MovimentoManual { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoMapping());
            modelBuilder.ApplyConfiguration(new ProdutoCosifMapping());
            modelBuilder.ApplyConfiguration(new MovimentoManualMapping());

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}
