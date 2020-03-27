using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WirelessMediaTest.Application.Commands.ProductCommands;
using WirelessMediaTest.Application.DTO;
using WirelessMediaTest.EFDataAccess;

namespace WirelessMediaTest.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IAddProductCommand addProductCommand;
        private readonly WirelessMediaTestContext wirelessMediaTestContext;

        public ProductsController(IAddProductCommand addProductCommand, WirelessMediaTestContext wirelessMediaTestContext)
        {
            this.addProductCommand = addProductCommand;
            this.wirelessMediaTestContext = wirelessMediaTestContext;
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
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Products/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}