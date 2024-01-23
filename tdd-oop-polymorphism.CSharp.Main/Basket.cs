using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        List<IProducts> products = new List<IProducts>();

        public void add(IProducts product)
        {
            products.Add(product);
        }
        public int getTotal()
        {
            int total = 0;

            foreach (IProducts product in products)
            {
                total += product.getPrice();
            }

            return total;
        }

        public bool isInBasket(string name)
        {
            foreach (IProducts product in products)
            {
                if (product.getName().Equals(name))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
