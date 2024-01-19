using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        List<ICategory> games = new List<ICategory>();
        List<ICategory> drinks = new List<ICategory>();
        List<ICategory> books = new List<ICategory>();
        List<ICategory> categories = new List<ICategory>();

        public void add(ICategory category)
        {
            categories.Add(category);
            /*
            if (category is Game) { games.Add(category); return; }
            if (category is Drink) { drinks.Add(category); return;  }
            if (category is Book) {  books.Add(category); return; }
           
            throw new ArgumentException("Invalid category type. Must be an instance of Game, Drink, or Book.", nameof(category));
            */
        }        

        public int getTotal()
        {
            int total = 0;
            total = categories.Sum(c => c.getPrice());                    

            return total;
        }

        public bool isInBasket(String name)
        {
            ICategory? found = categories.Find(c => c.getName().Equals(name));
            return found != null ? true : false;            
        }
    }
}
