using System;
using System.Collections.Generic;
using System.Text;
using WirelessMediaTest.Application.DTO;

namespace WirelessMediaTest.Application.Commands.CategoryCommands
{
    public interface  IGetCategoriesCommand : ICommand<CategoryDTO, IEnumerable<CategoryDTO>>
    {

    }
}
