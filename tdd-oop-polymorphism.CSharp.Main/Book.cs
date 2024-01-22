using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Book : IProduct
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Book(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        // Commented out the old getter methods, because by using properties you can directly access the values 
        //using the property names (Name and Price) without needing explicit getter methods.

        /*
        public int getPrice()
        {
            return this.price;
        }

        public string getName()
        {
            return this.name;
        }
        */
    }
}
