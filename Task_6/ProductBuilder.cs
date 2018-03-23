using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    public class ProductBuilder
    {
        private Shop product;

        public ProductBuilder()
        {
            product = new Shop();
        }

        public ProductBuilder SetType(string type)
        {
            if (type.Equals(string.Empty))
            {
                throw new ArgumentException();
            }

            product.Type = type;
            return this;
        }
        public ProductBuilder SetName(string name)
        {
            if (name.Equals(string.Empty))
            {
                throw new ArgumentException();
            }

            product.Name = name;
            return this;
        }
        public ProductBuilder SetQuantity(string quantity)
        {
            product.Quantity = UInt32.Parse(quantity);
            return this;
        }
        public ProductBuilder SetQuantity(uint quantity)
        {
            product.Quantity = quantity;
            return this;
        }
        public ProductBuilder SetCostPerUnit(string costPerUnit)
        {
            float cost = Single.Parse(costPerUnit);

            if (cost < 0)
            {
                throw new ArgumentException();
            }

            product.CostPerUnit = cost;
            return this;
        }
        public ProductBuilder SetCostPerUnit(float costPerUnit)
        {
            if (costPerUnit < 0)
            {
                throw new ArgumentException();
            }

            product.CostPerUnit = costPerUnit;
            return this;
        }

        public Shop Build()
        {
            return product;
        }
    }
}
