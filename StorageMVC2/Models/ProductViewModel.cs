﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorageMVC2.Models
{
    public class ProductViewModel:Product
    {
        
       // public string Name { get; set; }
       // public int Price { get; set; }
       // public int Count { get; set; }
        public IEnumerable<Product> product { get; set; }
        public int InventoryValue { get; set; }
    }
}
