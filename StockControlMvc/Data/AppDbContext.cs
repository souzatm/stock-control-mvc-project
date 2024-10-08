using Microsoft.EntityFrameworkCore;
using StockControlMvc.Entities;

namespace StockControlMvc.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Produto>()
                .HasOne(f => f.Fornecedor)
                .WithMany(p => p.Produtos)
                .HasForeignKey(p => p.FornecedorId);
        }
    }
}
