using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        List<IItem> items = new List<IItem>();

        public void Add(IItem item)
        {
            this.items.Add(item);
        }



        public int getTotal()
        {
            int total = 0;

            foreach (IItem item in this.items)
            {
                total += item.getPrice();
            }


            return total;
        }

        public bool isInBasket(String name)
        {
            foreach (IItem item in this.items)
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
