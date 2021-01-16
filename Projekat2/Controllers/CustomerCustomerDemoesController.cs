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
    public class CustomerCustomerDemoesController : Controller
    {
        private readonly NorthwindContext _context;

        public CustomerCustomerDemoesController(NorthwindContext context)
        {
            _context = context;
        }

        // GET: CustomerCustomerDemoes
        public async Task<IActionResult> Index()
        {
            var northwindContext = _context.CustomerCustomerDemo.Include(c => c.Customer).Include(c => c.CustomerType);
            return View(await northwindContext.ToListAsync());
        }
 
        // GET: CustomerCustomerDemoes/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerId");
            ViewData["CustomerTypeId"] = new SelectList(_context.CustomerDemographics, "CustomerTypeId", "CustomerTypeId");
            return View();
        }

        // POST: CustomerCustomerDemoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,CustomerTypeId")] CustomerCustomerDemo customerCustomerDemo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customerCustomerDemo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerId", customerCustomerDemo.CustomerId);
            ViewData["CustomerTypeId"] = new SelectList(_context.CustomerDemographics, "CustomerTypeId", "CustomerTypeId", customerCustomerDemo.CustomerTypeId);
            return View(customerCustomerDemo);
        }

        private bool CustomerCustomerDemoExists(string id)
        {
            return _context.CustomerCustomerDemo.Any(e => e.CustomerId == id);
        }
    }
}
