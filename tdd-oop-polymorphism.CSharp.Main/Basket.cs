using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {

        private List<Item> items = new();

        public void add(Item item)
        {
            this.items.Add(item);
        }

        public int getTotal()
        {
            int total = 0;

            foreach (Item item in items)
            {
                total += item.getPrice();
            }

            return total;
        }

        public bool isInBasket(String name)
        {
            
            if (items.ToList().Where(x => x.getName() == name).ToList().Count > 0)
            {
                return true;
            }

            return false;
        }
    }
}
