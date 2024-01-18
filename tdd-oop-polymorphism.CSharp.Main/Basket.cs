using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        List<Game> games = new List<Game>();
        List<Drink> drinks = new List<Drink>();
        List<Book> books = new List<Book>();

        List<Item> items = new List<Item>();

        public void add(Item item)
        {
            items.Add(item);
        }

        public int getTotal()
        {
            int total = 0;

            foreach (Item item in this.items)
                total += item.getPrice();

            return total;
        }

        public bool isInBasket(String name)
        {
            foreach (Item item in this.items)
            {
                if (item.getName().Equals(name))
                    return true;
            }

            return false;
        }
    }
}
