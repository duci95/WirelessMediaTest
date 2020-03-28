using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WirelessMediaTest.Web.Models
{
    public class ProductDTOModel
    {
        public string ProductName { get; set; }        
        public string ProductDesc { get; set; }        
        public double ProductPrice { get; set; }
        public int CategoryId { get; set; }
        public int ManufacturerId { get; set; }        
        public int VendorId { get; set; }
    }
}