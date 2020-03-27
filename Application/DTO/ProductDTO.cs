using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WirelessMediaTest.Application
{
    public class ProductDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name of the product is required")]
        [MinLength(3, ErrorMessage = "Name of the product cannot be shorter than 3")]
        [MaxLength(50, ErrorMessage = "Name of the product cannot be longer than 50")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Description of the product is required")]
        public string ProductDesc { get; set; }
        [Required(ErrorMessage = "Price of the product is required")]
        public double ProductPrice { get; set; }
        [Required]
        public int ManufacturerVendorId { get; set; }
    }
}