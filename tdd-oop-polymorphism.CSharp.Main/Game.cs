﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Game : Item
    {
        public Game(string name, int price) : base(name, price)
        {
        }
    }
}
