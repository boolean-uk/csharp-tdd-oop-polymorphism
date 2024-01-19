using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
      private List<Interface1> list = new List<Interface1>();

        public void add(Interface1 item)
        {
            list.Add(item);
        }
        public int getTotal()
        {
            int total = 0;

            foreach (var item in list)
            {
                total += item.price;
            }
            return total;
        }
        public bool isInBasket(String name)
        {
           return list.Any(item => item.Name == name);
        }
    }
}
