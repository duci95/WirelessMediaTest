using System;
using System.Collections.Generic;
using System.Text;

namespace WirelessMediaTest.Domain
{
    public class Vendor : BaseEntity
    {
        public string VendorName { get; set; }

        public ICollection<ManufacturerVendor> ManufacturerVendors { get; set; }
    }
}
