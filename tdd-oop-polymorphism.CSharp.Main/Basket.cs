using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public interface Items
    {
        int getPrice();
        string getName();
    }
    public class Basket
    {
        List<Items> items = new List<Items>();

        public void add(Items item)
        {
            this.items.Add(item);
        }
        public int getTotal()
        {
            int total = 0;
            foreach (Items item in this.items)
            {
                total += item.getPrice();
            }

            return total;
        }

        public bool isInBasket(String name)
        {
            foreach (Items item in this.items)
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
