using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WirelessMediaTest.Application;
using WirelessMediaTest.Application.Commands.ProductCommands;
using WirelessMediaTest.Application.DTO;
using WirelessMediaTest.Application.Exceptions;
using WirelessMediaTest.EFDataAccess;

namespace WirelessMediaTest.EFCommands.EFProductCommands
{
    public class EFEditProductCommand : EFBase, IEditProductCommand
    {
        public EFEditProductCommand(WirelessMediaTestContext context) : base(context)
        {
        }

        public void Operation(EditProductDTO req)
        {
            var data = Context.Products.Find(req.Id);

            if(data == null || data.Deleted)
                throw new DataNotFoundException();
            
            if(Context.Products.Any(p => p.ProductName == req.ProductName))
                throw new AlreadyExistsException();

            data.ProductName = req.ProductName;
            data.ProductDesc = req.ProductDesc;           
            data.ProductPrice = req.ProductPrice;          
            data.VendorId = req.VendorId;            
            data.ManufacturerId = req.ManufacturerId;           
            data.CategoryId = req.CategoryId;

            data.UpdatedAt = DateTime.Now;
            Context.SaveChanges();
        }        
    }
}
