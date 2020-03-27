using System;
using System.Collections.Generic;
using System.Text;

namespace WirelessMediaTest.Application.Commands.ProductCommands
{
    public interface IGetProductsCommand : ICommand<ProductDTO, IEnumerable<ProductDTO>>
    {
        
    }
}
