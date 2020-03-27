using System;
using System.Collections.Generic;
using System.Text;
using WirelessMediaTest.Application.DTO;

namespace WirelessMediaTest.Application.Commands.ManufacturerCommands
{
    public interface IGetManufacturersCommand : ICommand<ManufacturerDTO, IEnumerable<ManufacturerDTO>>
    {
       
    }
}
