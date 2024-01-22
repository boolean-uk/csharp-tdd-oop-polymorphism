using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        // New list to store products of any kind of type that implements IProduct

        List<IProduct> products = new List<IProduct>();

        /* Old code is no longer needed cause we just need a single list for all product types
         * thorugh common interface IProduct.
       
        List<Game> games = new List<Game>();
        List<Drink> drinks = new List<Drink>();
        List<Book> books = new List<Book>();
        */

        //Updated method to accept any Iproduct
        public void add(IProduct product)
        {
            this.products.Add(product);
        }

        // The following methods are no longer needed

        /*
        public void add(IProduct product)
        {
            this.products.Add(product);
        }

        public void add(Drink drink)
        {
            this.drinks.Add(drink);
        }

        public void add(Book book)
        {
            this.books.Add(book);
        }
        */

        //Updated method to calculae the total price using only the IProduct interface
        public int getTotal()
        {
            int total = 0;
            // Loop through the list of IProduct and add up their prices to calculate the total cos
            foreach (IProduct product in this.products)
            {
                total += product.Price;
            }

            return total;

            //The old code for separate loops for game, drink and books is no longer needed
            /*
            foreach (Game game in this.games)
            {
                total += game.getPrice();
            }

            foreach (Drink drink in this.drinks)
            {
                total += drink.getPrice();
            }

            foreach (Book book in this.books)
            {
                total += book.getPrice();
            }

            return total;
            */
            
        }
        // Loop through the list of products and check if any has a name that matches the specified name
        public bool isInBasket(string name)
        {
            foreach (IProduct product in this.products)
            {
                if (product.Name.Equals(name))
                {
                    return true;
                }
            }
            return false;


            // The old code with separate loops for games, drinks, and books is no longer needed
            /*
            foreach (Game game in this.games)
            {
                if (game.getName().Equals(name))
                {
                    return true;
                }
            }

            foreach (Drink drink in this.drinks)
            {
                if (drink.getName().Equals(name))
                {
                    return true;
                }
            }

            foreach (Book book in this.books)
            {
                if (book.getName().Equals(name))
                {
                    return true;
                }
            }
            return false;
            */
        }
    }
}
