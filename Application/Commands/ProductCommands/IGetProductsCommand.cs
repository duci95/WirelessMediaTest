using System;
using System.Collections.Generic;
using System.Text;

namespace WirelessMediaTest.Application.Commands.ProductCommands
{
    public interface IGetProductsCommand : ICommand<AddProductDTO, IEnumerable<AddProductDTO>>
    {
        
    }
}
