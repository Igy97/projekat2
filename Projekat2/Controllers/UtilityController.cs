using Microsoft.AspNetCore.Mvc;
using Projekat2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekat2.Controllers
{
    public class UtilityController : Controller
    {
        private readonly NorthwindContext _context;

        public UtilityController(NorthwindContext context)
        {
            _context = context;
        }
        public IActionResult AddCustomersOrCustomersDemographics()
        {
            CustomerAndCustomerDemographics model = new CustomerAndCustomerDemographics();
            model.customerDemographics = _context.CustomerDemographics.ToList();
            return View(model);
        }
    }
}
