using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        List<Interface1> _products = new List<Interface1>();

        public void add(Interface1 product)
        {
            _products.Add(product);
        }

     

        public int getTotal()
        {
            int total = 0;

            foreach (Interface1 item in _products)
            {
                total += item.price;
            }

            return total;
        }

        public bool isInBasket(String name)
        {
           foreach (Interface1 item in _products)
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
