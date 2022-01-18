using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SlnErp102.Core.Models.Stocks.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnErp102.Data.Configuration.Stocks.Products
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).UseIdentityColumn();
            builder.Property(s => s.ProductCode).IsRequired().HasMaxLength(20);
            builder.Property(s => s.Description).HasMaxLength(250);
            builder.Property(s => s.Picture).HasMaxLength(250);
            builder.Property(s => s.SutCode).HasMaxLength(50);
            builder.Property(s => s.SutDescription).HasMaxLength(250);
            builder.Property(s => s.SutPrice).HasPrecision(14,2);
            builder.Property<DateTime>(s => s.EntryDate).HasColumnType("date");
            builder.Property<DateTime>(s => s.CreatedOn).HasColumnType("date");
            builder.Property<DateTime>(s => s.ModifiedOn).HasColumnType("date");
            builder.Property(s => s.ModifiedUser).HasMaxLength(50);
            builder.ToTable("tblProducts");
        }
    }
    
}
