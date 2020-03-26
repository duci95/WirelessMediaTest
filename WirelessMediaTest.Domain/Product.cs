using System;
using System.Collections.Generic;
using System.Text;

namespace WirelessMediaTest.Domain
{
    public class Product : BaseEntity   
    {
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public double ProductPrice { get; set; }
        public Category Category { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public Vendor Vendor { get; set; }
    }
}
