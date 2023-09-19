using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        private List<IProduct> products = new List<IProduct>();

        public void add(IProduct product)
        {
            products.Add(product);
        }

        public int getTotal()
        {
            int total = 0;

            foreach (IProduct product in products)
            {
                total += product.getPrice();
            }

            return total;
        }

        public bool isInBasket(string name)
        {
            return products.Any(product => product.getName().Equals(name));
        }
    }
}