using BNP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BNP.Data.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(x => x.IdCategory);           
            builder.HasIndex(c => new { c.IdCategory });

            builder.Property(c => c.Description).HasColumnType("varchar(100)").IsRequired();
            builder.Property(c => c.Active).IsRequired();
        }
    }
}
