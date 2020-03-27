using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WirelessMediaTest.Application;
using WirelessMediaTest.Application.Commands.ProductCommands;
using WirelessMediaTest.Application.Exceptions;
using WirelessMediaTest.Domain;
using WirelessMediaTest.EFDataAccess;

namespace WirelessMediaTest.EFCommands.EFProductCommands
{
    public class EFAddProductCommand : EFBase, IAddProductCommand
    {
        public EFAddProductCommand(WirelessMediaTestContext wirelessMediaTestContext) : base(wirelessMediaTestContext)
        {

        }
        public void Operation(AddProductDTO req)
        {
            if (Context.Products.Any(p => p.ProductName == req.ProductName))
            {
                //this exception is thrown if there is already product with same name
                throw new AlreadyExistsException("Name of the product already exists");
            }

            
            Context.Products.Add(new Product
            {
                ProductName = req.ProductName,
                ProductDesc = req.ProductDesc,
                ProductPrice = req.ProductPrice,
                CategoryId = req.CategoryId,
                VendorId = req.VendorId,
                ManufacturerId = req.ManufacturerId                
            });

            Context.SaveChanges();
        }
    }
}
