using System;
using System.Collections.Generic;
using System.Text;

namespace WirelessMediaTest.Domain
{
    public class Manufacturer : BaseEntity
    {
        public string ManufacturerName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
