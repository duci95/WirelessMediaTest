using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WirelessMediaTest.Web.Models
{
    public class ProductsIndexViewModel
    {
        public IEnumerable<ProductDTOModel> Products { get; set; }
    }
}
