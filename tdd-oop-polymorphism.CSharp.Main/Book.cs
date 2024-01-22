using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_polymorphism.CSharp.Main.Interfaces;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Book : IProduct
    {
        string _name;
        int _price;

        public string Name { get => _name; set => _name = value; }
        public int Price { get => _price; set => _price = value; }

        public Book(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
