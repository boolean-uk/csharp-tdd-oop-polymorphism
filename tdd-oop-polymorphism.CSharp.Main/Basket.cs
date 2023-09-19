using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        List<IProduct> products = new List<IProduct>();

        public void add(IProduct product)
        {
            this.products.Add(product);
        }

        public void remove(IProduct product)
        {
            this.products.Remove(product);
        }

        public int getTotal()
        {
            int total = 0;

            foreach (IProduct product in this.products)
            {
                total += product.getPrice();
            }
            return total;
        }

        // https://learn.microsoft.com/en-us/dotnet/api/system.stringcomparer.ordinalignorecase?view=net-7.0 used StringComparer.OrdinalIgnoreCase Property
        public bool isInBasket(String name)
        {
            foreach (IProduct product in this.products)
            {
                if (product.getName().Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
