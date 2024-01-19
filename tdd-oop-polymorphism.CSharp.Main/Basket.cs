using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        List<Interface1> list = new List<Interface1>();

        public void add(Interface1 item)
        {
            this.list.Add(item);
        }
        public int getTotal()
        {
            int total = 0;

            foreach (Interface1 item in list)
            {
                total += item.price;
            }
            return total;
        }
        public bool isInBasket(String name)
        {
            foreach (Interface1 item in list)
            {
                if (item.Name.Equals(name))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
