using System;
using System.Collections.Generic;
using System.Text;
using WirelessMediaTest.Application.DTO;

namespace WirelessMediaTest.Application.Commands.ProductCommands
{
    public interface IGetProductsCommand : ICommand<ProductDTO, IEnumerable<ProductsDTO>>
    {
         
    }
}
