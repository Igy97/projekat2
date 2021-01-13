using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projekat2.Models;

namespace Projekat2.Controllers
{
    public class ProductsController : Controller
    {
        private readonly NorthwindContext _context;

        public ProductsController(NorthwindContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            FilterProducts filterProducts = new FilterProducts();
            filterProducts.Categories = await _context.Categories.ToListAsync();
            filterProducts.Suppliers = await _context.Suppliers.ToListAsync();
            filterProducts.productsList = await _context.Products.ToListAsync();
            var categories = await _context.Categories.ToListAsync();
            Categories category = new Categories();
            category.CategoryId = -1;
            category.CategoryName = "Select Category";
            categories.Insert(0, category);
            ViewData["CategoryId"] = new SelectList(categories, "CategoryId", "CategoryName", "Select Category");
            var suppliers = await _context.Suppliers.ToListAsync();
            Suppliers supplier = new Suppliers();
            supplier.SupplierId = -1;
            supplier.CompanyName = "Select Company";
            suppliers.Insert(0, supplier);
            ViewData["SupplierId"] = new SelectList(suppliers, "SupplierId", "CompanyName", "Select Supplier");
            return View(filterProducts);
        }

        // POST: Filter
        [HttpPost]
        public async Task<IActionResult> Filter(FilterProducts filterProducts)
        {
            if (filterProducts.CategoryId != -1 && filterProducts.SupplierId != -1)
            {
                var products = from product in _context.Products
                               where product.CategoryId == filterProducts.CategoryId && product.SupplierId == filterProducts.SupplierId
                               select product;
                filterProducts.productsList = await products.ToListAsync();
            } else
            {
                filterProducts.productsList = await _context.Products.ToListAsync();
            }
            var categories = await _context.Categories.ToListAsync();
            Categories category = new Categories();
            category.CategoryId = -1;
            category.CategoryName = "Select Category";
            categories.Insert(0, category);
            ViewData["CategoryId"] = new SelectList(categories, "CategoryId", "CategoryName", "Select Category");
            var suppliers = await _context.Suppliers.ToListAsync();
            Suppliers supplier = new Suppliers();
            supplier.SupplierId = -1;
            supplier.CompanyName = "Select Company";
            suppliers.Insert(0, supplier);
            ViewData["SupplierId"] = new SelectList(suppliers, "SupplierId", "CompanyName", "Select Supplier");
            return View("~/Views/Products/Index.cshtml", filterProducts);
        }




      
    }
}
