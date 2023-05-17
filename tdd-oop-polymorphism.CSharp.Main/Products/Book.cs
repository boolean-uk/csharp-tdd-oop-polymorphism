using Interfaces_oop_polymorphism.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_polymorphism.CSharp.Main;

namespace Products
{
    public class Book : IProduct
    {
        public string name;
        public int price;

        public Book(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public int getPrice()
        {
            return price;
        }

        public string getName()
        {
            return name;
        }
    }
}
