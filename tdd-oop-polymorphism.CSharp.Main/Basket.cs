using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        List<IBasketItem> items = new List<IBasketItem>();

        public void add(IBasketItem item)
        {
            this.items.Add(item);
        }

        public int getTotal()
        {
            int total = 0;
            foreach (IBasketItem item in items) 
            {
                total += item.getPrice();
            }
            return total;
        }

        public bool isInBasket(String name)
        {
            foreach (IBasketItem item in items) 
            {
                if (item.getName() == name) 
                {
                    return true;
                }
            }

            return false;
        }
    }
}
