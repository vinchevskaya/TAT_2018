using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_6
{
    class CountTypes : ICommandStore
    {
        /// <summary>
        /// This method for count types products.
        /// </summary>
        public void Work(List<Shop> productList)
        {
            List<string> uniqueProductList = new List<string>();

            foreach (var a in productList)
            {
                uniqueProductList.Add(a.Type);
            }

            Console.WriteLine("\nCountTypes: " + uniqueProductList.Distinct().Count());
        }
    }
}
