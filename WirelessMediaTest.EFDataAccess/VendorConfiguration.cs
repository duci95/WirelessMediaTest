using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WirelessMediaTest.Domain;

namespace WirelessMediaTest.EFDataAccess
{
    public class VendorConfiguration : IEntityTypeConfiguration<Vendor>
    {
        public void Configure(EntityTypeBuilder<Vendor> builder)
        {
            builder.Property(v => v.VendorName).IsRequired();
            builder.Property(v => v.Deleted).HasDefaultValue(false);
            builder.Property(v => v.CreatedAt).HasDefaultValueSql("GETDATE()");
        }
    }
}