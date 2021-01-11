using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekat2.Models
{
    public class CustomerAndCustomerDemographics
    {
        public Customers customers { get; set; }
        public IEnumerable<CustomerDemographics> customerDemographics { get; set; }
    }
}
