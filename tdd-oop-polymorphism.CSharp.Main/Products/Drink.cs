using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    public class Drink : IProduct
    {
        string name;
        decimal price;

        public Drink(string name, decimal price)
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
