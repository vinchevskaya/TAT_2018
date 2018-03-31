using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class AveragePriceType : ICommandStore
    {
        private string type;

        public AveragePriceType(string type)
        {
            this.type = type;
        }

        public void Work(List<Shop> productList)
        {
            var typeProductList = productList.Where(product => product.Type == type);
            var priceList = new List<float>();

            foreach (var a in typeProductList)
            {
                priceList.Add(a.CostPerUnit);
            }

            Console.WriteLine("\nAveragePriceType: " + (float)priceList.Average());
        }
    }
}
