using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WirelessMediaTest.Domain
{
    public class ManufacturerVendor
    {
        public int Id { get; set; }
        public int ManufacturerId { get; set; }
        public int VendorId { get; set; }

        public Manufacturer Manufacturer { get; set; }
        public Vendor Vendor { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
