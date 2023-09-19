using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Game : IProduct
    {
        public string name { get; set; }
        public int price { get; set; }

        public Game(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public int getPrice()
        {
            return this.price;
        }

        public string getName()
        {
            return this.name;
        }
    }
}
