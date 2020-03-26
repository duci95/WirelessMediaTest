using System;
using System.Collections.Generic;
using System.Text;

namespace WirelessMediaTest.Domain
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
