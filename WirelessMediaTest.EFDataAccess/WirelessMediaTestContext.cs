using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WirelessMediaTest.Domain;

namespace WirelessMediaTest.EFDataAccess
{
    public class WirelessMediaTestContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
