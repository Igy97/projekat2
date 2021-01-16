using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projekat2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekat2.Controllers
{
    public class CountOfEmployeesController : Controller
    {
        private readonly NorthwindContext _context;

        public CountOfEmployeesController(NorthwindContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            RegionTeritoryCountEmployee regionTeritoryCountEmployee = new RegionTeritoryCountEmployee();
            var regions = await _context.Region.ToListAsync();
            Region region = new Region();
            region.RegionId = -1;
            region.RegionDescription = "Select Region";
            regions.Insert(0, region);
            regionTeritoryCountEmployee.RegionId = -1;
            ViewData["RegionId"] = new SelectList(regions, "RegionId", "RegionDescription");
            return View(regionTeritoryCountEmployee);
        }

        [HttpPost]
        public async Task<IActionResult> Filter(RegionTeritoryCountEmployee regionTeritoryCountEmployee)
        {
            if (regionTeritoryCountEmployee.RegionId != -1)
            {
                var countOfEmployees = from x in _context.EmployeeTerritories
                                       group x.EmployeeId by x.TerritoryId into g
                                       select new { TerritoryId = g.Key, CountOfEmployee = g.Count() };

                var countOfEmployeesTerritories = from x in countOfEmployees
                                                  join t in _context.Territories on x.TerritoryId equals t.TerritoryId
                                                  where t.RegionId == regionTeritoryCountEmployee.RegionId
                                                  select new { x.TerritoryId, t.TerritoryDescription, x.CountOfEmployee, t.RegionId };

                var listOfcountOfEmployeesTerritories = await countOfEmployeesTerritories.ToListAsync();
                int sumOfEmployeesForRegion = 0;

                List<TerritoriesCountEmployee> listTerritoriesCountEmployee = new List<TerritoriesCountEmployee>();

                foreach (var item in listOfcountOfEmployeesTerritories)
                {
                    TerritoriesCountEmployee territoriesCountEmployee = new TerritoriesCountEmployee();
                    territoriesCountEmployee.territory = new Territories();
                    territoriesCountEmployee.territory.RegionId = item.RegionId;
                    territoriesCountEmployee.territory.TerritoryDescription = item.TerritoryDescription;
                    territoriesCountEmployee.territory.TerritoryId = item.TerritoryId;
                    territoriesCountEmployee.countOfEmployees = item.CountOfEmployee;
                    listTerritoriesCountEmployee.Add(territoriesCountEmployee);
                    sumOfEmployeesForRegion += item.CountOfEmployee;
                }
                regionTeritoryCountEmployee.territoriesCountEmployee = listTerritoriesCountEmployee;
                regionTeritoryCountEmployee.sumOfEmployees = sumOfEmployeesForRegion;       
            }
            else
            {
                regionTeritoryCountEmployee = new RegionTeritoryCountEmployee();
                regionTeritoryCountEmployee.RegionId = -1;
            }
            var regions = await _context.Region.ToListAsync();
            Region region = new Region();
            region.RegionId = -1;
            region.RegionDescription = "Select Region";
            regions.Insert(0, region);
            ViewData["RegionId"] = new SelectList(regions, "RegionId", "RegionDescription");

            return View("~/Views/CountOfEmployees/Index.cshtml", regionTeritoryCountEmployee);
        }

    }
}
