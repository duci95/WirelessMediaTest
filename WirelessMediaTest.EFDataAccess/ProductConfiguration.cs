using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WirelessMediaTest.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace WirelessMediaTest.EFDataAccess
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.ProductName).HasMaxLength(50);
            
            builder.Property(p => p.ProductName).IsRequired();
            builder.Property(p => p.ProductDesc).IsRequired();
            builder.Property(p => p.ProductPrice).IsRequired();

            builder.Property(p => p.Deleted).HasDefaultValue(false);
            builder.Property(p => p.CreatedAt).HasDefaultValueSql("GETDATE()");
        }
    }
}
