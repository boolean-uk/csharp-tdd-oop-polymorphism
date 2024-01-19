﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{

    public abstract class Item
    {
        string name;
        int price; 

        public Item (string name, int price)
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