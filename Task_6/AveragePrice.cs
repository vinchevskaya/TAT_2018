﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class AveragePrice : ICommandStore
    {
        public void Work(List<Shop> productList)
        {
            var priceList = new List<float>();

            foreach (var a in productList)
            {
                priceList.Add(a.CostPerUnit);
            }

            Console.WriteLine("\nAveragePrice: " + (float)priceList.Average());
        }
    }
}
