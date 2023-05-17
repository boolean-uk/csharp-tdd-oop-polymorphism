using Interfaces;
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
        decimal price;

        public Game(string name, decimal price)
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
