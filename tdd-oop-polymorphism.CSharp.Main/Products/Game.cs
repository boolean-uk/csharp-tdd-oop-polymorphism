using Interfaces_oop_polymorphism.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    public class Game : IProduct
    {
        string name;
        int price;

        public Game(string name, int price)
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
