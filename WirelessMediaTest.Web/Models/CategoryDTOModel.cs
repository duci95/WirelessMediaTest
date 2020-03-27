using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WirelessMediaTest.Application.DTO;

namespace WirelessMediaTest.Web.Models
{
    public class CategoryDTOModel
    {
        public IEnumerable<CategoryDTO> Categories { get; set; }
    }
}
