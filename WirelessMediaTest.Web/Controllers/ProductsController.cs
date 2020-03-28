using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WirelessMediaTest.Application;
using WirelessMediaTest.Application.Commands.ProductCommands;
using WirelessMediaTest.Application.DTO;
using WirelessMediaTest.Application.Exceptions;
using WirelessMediaTest.EFDataAccess;
using WirelessMediaTest.Web.Models;

namespace WirelessMediaTest.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IAddProductCommand addProductCommand;
        private readonly IGetProductCommand getProductCommand;
        private readonly IEditProductCommand editProductCommand;
        private readonly WirelessMediaTestContext wirelessMediaTestContext;

        public ProductsController(
            IAddProductCommand addProductCommand,
            IGetProductCommand getProductCommand,
            IEditProductCommand editProductCommand,
            WirelessMediaTestContext wirelessMediaTestContext
            )
        {
            this.addProductCommand = addProductCommand;
            this.getProductCommand = getProductCommand;
            this.editProductCommand = editProductCommand;
            this.wirelessMediaTestContext = wirelessMediaTestContext;
        }

        // GET: Products
        public ActionResult Index()
        {
            ViewBag.Products = wirelessMediaTestContext.Products.Select(p => new ProductsDTO
            {
                Id = p.Id,
                ProductName = p.ProductName,
                ProductDesc = p.ProductDesc,
                ProductPrice = p.ProductPrice,
                CategoryName = p.Category.CategoryName,
                ManufacturerName = p.Manufacturer.ManufacturerName,
                VendorName = p.Vendor.VendorName
            });
            return View();
        }

        // GET: Products/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            ViewBag.Categories = wirelessMediaTestContext.Categories.Select(c => new CategoryDTO
            {
                CategoryName = c.CategoryName,
                Id = c.Id
            });

            ViewBag.Manufacturers = wirelessMediaTestContext.Manufacturers.Select(m => new ManufacturerDTO
            {
                ManufacturerName = m.ManufacturerName,
                Id = m.Id
            });

            ViewBag.Vendors = wirelessMediaTestContext.Vendors.Select(v => new VendorDTO
            {
                VendorName = v.VendorName,
                Id = v.Id
            });

            return View();
        }

        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductDTOModel addProductDTOModel)
        {
            try
            {
                var product = new ProductDTO
                {
                    ProductName = addProductDTOModel.ProductName,
                    CategoryId = addProductDTOModel.CategoryId,
                    ManufacturerId = addProductDTOModel.ManufacturerId,
                    ProductDesc = addProductDTOModel.ProductDesc,
                    ProductPrice = addProductDTOModel.ProductPrice,
                    VendorId = addProductDTOModel.VendorId
                };

                addProductCommand.Operation(product);
                return RedirectToAction(nameof(Index));
            }
            catch (AlreadyExistsException)
            {
                TempData["error"] = "Product name already exists.";
                return View();
            }
            catch
            {
                return View();
            }

        }

        // GET: Products/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                var data = getProductCommand.Operation(id);
                return View(data);
            }
            catch (DataNotFoundException)
            {
                TempData["error"] = "Product not found.";
                return View();
            }
            catch (Exception)
            {
                return View();
            }
            
        }

        // POST: Products/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EditProductDTO collection)
        {
            try
            {
                editProductCommand.Operation(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}