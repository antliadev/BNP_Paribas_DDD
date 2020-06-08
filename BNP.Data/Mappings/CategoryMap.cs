using BNP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BNP.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(x => x.IdProduct);

            builder.HasOne(e => e.Category).WithMany(c => c.Products);

            builder.HasIndex(c => new { c.IdProduct });

            builder.Property(c => c.Description).HasColumnType("varchar(100)").IsRequired();
            builder.Property(c => c.Active).IsRequired();
        }
    }
}
