using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WirelessMediaTest.Domain;

namespace WirelessMediaTest.EFDataAccess
{
    public class ManufacturerVendorConfiguration : IEntityTypeConfiguration<ManufacturerVendor>
    {
        public void Configure(EntityTypeBuilder<ManufacturerVendor> builder)
        {
            builder.HasAlternateKey(mv => new { mv.ManufacturerId, mv.VendorId });

        }
    }
}