﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekat2.Models
{
    public class FilterProducts
    {
        public IEnumerable<Products> productsList { get; set; }
 
        public int? SupplierId { get; set; }
        public int? CategoryId { get; set; }
    }
}
