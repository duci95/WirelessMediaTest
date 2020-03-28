using System;
using System.Collections.Generic;
using System.Text;

namespace WirelessMediaTest.Application.DTO
{
    public class ProductsDTO
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public double ProductPrice { get; set; }
        public string CategoryName { get; set; }
        public string VendorName { get; set; }
        public string ManufacturerName { get; set; }
    }
}
