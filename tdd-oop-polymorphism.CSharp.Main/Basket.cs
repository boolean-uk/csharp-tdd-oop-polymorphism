using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        List<Product> products = new();
        

        public void add(Product product)
        {
            this.products.Add(product);
        }

        public int getTotal()
        {
            int total = 0;

            foreach (Product product in products)
            {
                total += product.getPrice();
            }

            return total;
        }

        public bool isInBasket(String name)
        {
            foreach (Product product in this.products)
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
