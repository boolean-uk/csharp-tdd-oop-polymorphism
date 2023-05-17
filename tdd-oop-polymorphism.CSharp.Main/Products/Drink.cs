using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_polymorphism.CSharp.Main.Interfaces;

namespace Products
{
    public class Drink : IProduct
    {
        string name;
        int price;

        public Drink(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public int GetPrice()
        {
            return price;
        }

        public string GetName()
        {
            return name;
        }
    }
}
