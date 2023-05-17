using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        List<MyInterface> list = new List<MyInterface>();

        public void add(MyInterface myinterface)
        {
            this.list.Add(myinterface);
        }

        public int getTotal()
        {
            int total = 0;

            foreach (MyInterface item in list)
            {
                total += item.price;
            }
            return total;
        }

        public bool isInBasket(String name)
        {
            foreach (MyInterface item in list)
            {
                if (item.name.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
