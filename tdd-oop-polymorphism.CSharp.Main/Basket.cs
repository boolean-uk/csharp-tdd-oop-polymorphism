using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        List<IProduct> _products = new List<IProduct>();

        public void add(IProduct product)
        {
            _products.Add(product);
        }

     

        public int getTotal()
        {
            int total = 0;

            foreach (IProduct item in _products)
            {
                total += item.price;
            }

            return total;
        }

        public bool isInBasket(String name)
        {
           foreach (IProduct item in _products)
            {
                if (item.name == name)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
