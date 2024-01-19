using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        List<IProduct> basket = new List<IProduct>();
   

        public void add(IProduct item)
        {
            this.basket.Add(item);
        }


        public int getTotal()
        {
            int total = 0;

            foreach (IProduct item in this.basket)
            {
                total += item.getPrice();
            }

            return total;
        }

        public bool isInBasket(String name)
        {
            foreach (IProduct item in this.basket)
            {
                if (item.getName().Equals(name))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
