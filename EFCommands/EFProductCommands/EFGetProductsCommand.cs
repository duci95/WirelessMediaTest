using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WirelessMediaTest.Application;
using WirelessMediaTest.Application.Commands.ProductCommands;
using WirelessMediaTest.Application.DTO;
using WirelessMediaTest.EFDataAccess;

namespace WirelessMediaTest.EFCommands.EFProductCommands
{
    public class EFGetProductsCommand : EFBase, IGetProductsCommand
    {
        protected EFGetProductsCommand(WirelessMediaTestContext context) : base(context)
        {
        }

        public IEnumerable<ProductsDTO> Operation(ProductDTO req)
        {
            var data = Context.Products.AsQueryable();

            return data.Select(p => new ProductsDTO
            {
                ProductName = p.ProductName,
                ProductDesc = p.ProductDesc,
                ProductPrice = p.ProductPrice,
                CategoryName = p.Category.CategoryName,
                ManufacturerName = p.Manufacturer.ManufacturerName,
                VendorName = p.Vendor.VendorName
            }).ToList();
        }
    }
}
