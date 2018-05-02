using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_6
{
    class CountAll : ICommandStore
    {
        /// <summary>
        /// Method for count all types product.
        /// </summary>
        public void Work(List<Shop> productList)
        {
            Console.WriteLine("\nCountAll: " + productList.Distinct().Count());
        }
    }
}
