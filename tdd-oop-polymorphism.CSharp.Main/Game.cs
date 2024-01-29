using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Game : IProduct
    {
        private string _name;
        private int _price;

        public string Name { get { return _name; } set { _name = value; } }
        public int Price { get { return _price; } set { _price = value; } }

        public Game(string name, int price)
        {
            this._name = name;
            this._price = price;
        }

    }
}
