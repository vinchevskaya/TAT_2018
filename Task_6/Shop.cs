﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    public class Shop
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public uint Quantity { get; set; }
        public float CostPerUnit { get; set; }


        public static ProductBuilder CreateBuilder()
        {
            return new ProductBuilder();
        }
    }
}
