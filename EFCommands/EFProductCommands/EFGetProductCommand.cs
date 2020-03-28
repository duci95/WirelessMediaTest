using System;
using System.Collections.Generic;
using System.Text;
using WirelessMediaTest.Application;
using WirelessMediaTest.Application.Commands.ProductCommands;
using WirelessMediaTest.Application.DTO;
using WirelessMediaTest.Application.Exceptions;
using WirelessMediaTest.EFDataAccess;

namespace WirelessMediaTest.EFCommands.EFProductCommands
{
    public class EFGetProductCommand : EFBase, IGetProductCommand
    {
        public EFGetProductCommand(WirelessMediaTestContext context) : base(context)
        {

        }

        public EditProductDTO Operation(int req)
        {
            var data = Context.Products.Find(req);

            if (data == null || data.Deleted)
                throw new DataNotFoundException();

            return new EditProductDTO
            {
                Id = data.Id,
                ProductName = data.ProductName,
                ProductDesc = data.ProductDesc,
                ProductPrice = data.ProductPrice,
                CategoryId = data.CategoryId,
                ManufacturerId = data.ManufacturerId,
                VendorId = data.VendorId
            };
        }
    }
}
