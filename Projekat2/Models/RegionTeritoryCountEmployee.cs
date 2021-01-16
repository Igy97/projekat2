using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekat2.Models
{
    public class RegionTeritoryCountEmployee
    {
        public IEnumerable<TerritoriesCountEmployee> territoriesCountEmployee { get; set; }
        public int sumOfEmployees { get; set; }
        public int RegionId { get; set; }

    }
}
