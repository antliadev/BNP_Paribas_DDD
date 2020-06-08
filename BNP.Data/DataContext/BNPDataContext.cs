using BNP.Data.Mappings;
using BNP.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BNP.Data.DataContext
{
    public class BNPDataContext : DbContext
    {
        public BNPDataContext(DbContextOptions<BNPDataContext> options)
        : base(options)
        { }

        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Category> Category { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
