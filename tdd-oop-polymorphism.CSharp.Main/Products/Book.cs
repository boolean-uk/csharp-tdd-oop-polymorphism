using Interfaces;
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
        string name;
        decimal price;

        public Book(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public decimal getPrice()
        {
            return price;
        }

        public string getName()
        {
            return name;
        }
    }
}
