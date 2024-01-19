using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        List<Item> goods = new List<Item>();

        public void add(Item good)
        {
            this.goods.Add(good);
        }


        public int getTotal()
        {
            int total = 0;

            foreach (Item good in this.goods)
            {
                total += good.getPrice();
            }

            return total;
        }

        public bool isInBasket(String name)
        {
            foreach (Item good in this.goods)
            {
                if (good.getName().Equals(name))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
