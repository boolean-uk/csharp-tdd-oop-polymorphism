﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static tdd_oop_polymorphism.CSharp.Main.Basket;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Game : IBasketItem
    {
        string name;
        int price;

        public Game(string name, int price)
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
