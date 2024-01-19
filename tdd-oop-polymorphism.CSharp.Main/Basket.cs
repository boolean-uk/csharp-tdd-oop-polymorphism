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

       /* List<Game> games = new List<Game>();
        List<Drink> drinks = new List<Drink>();
        List<Book> books = new List<Book>();*/

       /* public void add(Game game)
        {
            this.games.Add(game);
        }*/

        public void add(Interface1 interface1)
        {
            this.list.Add(interface1);
        }

        /*public void add(Book book)
        {
            this.books.Add(book);
        }*/

        public int getTotal()
        {
            int total = 0;

            foreach (Interface1 item in list)
            {
                total += item.price;
            }

            /*foreach (Drink drink in this.drinks)
            {
                total += drink.getPrice();
            }

            foreach (Book book in this.books)
            {
                total += book.getPrice();
            }*/

            return total;
        }

        public bool isInBasket(String name)
        {
            foreach (Interface1 item in list)
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
