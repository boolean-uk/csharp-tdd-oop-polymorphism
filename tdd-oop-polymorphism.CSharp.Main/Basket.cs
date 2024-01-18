using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {

        private List<IItem> items = new List<IItem>();

        public void add(IItem item) {
            items.Add(item);
        }

        public int getTotal() {
            int total = 0;
            foreach (IItem item in items) {
                total += item.getPrice();
            }
            return total;
        }

        public bool isInBasket(string item) {

            foreach (IItem iitem in items)
            {
                if (iitem.getName().Equals(item)) {
                    return true;
                }
            }

            return false;
        }
    }
}
