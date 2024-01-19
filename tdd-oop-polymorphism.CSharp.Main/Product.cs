using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public abstract class Product
{
        private string _name;
        private int _price;

        public Product(string name, int price)
        {
            _name = name;
            _price = price;
        }
        public int getPrice()
        {
            return this._price;
        }

        public string getName()
        {
            return this._name;
        }
    }
}
