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

        }
    }
}
