﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Drink : IObject
    {
        int _price;
        string _name;

        public int price { get; set; }
        public string name { get; set; }
    }
}
