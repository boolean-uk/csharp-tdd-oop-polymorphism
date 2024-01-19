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


        public int getTotal()
        {
            int total = 0;

            foreach (IProduct product in this.products)
            {
                total += product.getPrice();
            }

            return total;
        }

        public bool isInBasket(String name)
        {
            foreach (IProduct product in this.products)
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
