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
        List<ItemBase> Items = new List<ItemBase>();

        public void add(ItemBase item)
        {
            Items.Add(item);
        }

        public int getTotal()
        {
            int total = 0;

            foreach (ItemBase item in this.Items)
            {
                total += item.getPrice();
            }


            return total;
        }

        public bool isInBasket(String name)
        {
            foreach (ItemBase Item in this.Items)
            {
                if (Item.getName().Equals(name))
                {
                    return true;
                }
            }

    

            return false;
        }
    }
}
