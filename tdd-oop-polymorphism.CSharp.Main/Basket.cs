using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        List<IProduct> products = new();

        public void add(IProduct product)
        {
            products.Add(product);
        }

        public int getTotal()
        {
            return products.Sum(x => x.getPrice());
        }

        public bool isInBasket(String name)
        {
            return products.Any(x => x.getName().Equals(name));
        }
    }
}
