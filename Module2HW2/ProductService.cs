﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public class ProductService
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Currency Currency { get; set; }
    }
}
