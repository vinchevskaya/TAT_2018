using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class CountAll : ICommandStore
    {
        public void Work(List<Shop> productList)
        {
            Console.WriteLine("\nCountAll: " + productList.Distinct().Count());
        }
    }
}
