﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_RelatinshpEFCore.Entities
{
    public class Category
    {
        public int CategoryID { get; set; } 
        public string Name { get; set; }
        public List<Product> Products { get; set; } 

    }
}
