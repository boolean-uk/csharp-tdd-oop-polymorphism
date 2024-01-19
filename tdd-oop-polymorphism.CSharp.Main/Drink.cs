using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static tdd_oop_polymorphism.CSharp.Main.Basket;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Drink : IBasketItem
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
        
            return this.price;
          
        }

        public string GetName()
        {
            return this.name;
           
        }
    }
}
