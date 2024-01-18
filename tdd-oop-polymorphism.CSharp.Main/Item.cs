using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public abstract class Item
    {
        protected string name;
        protected int price;

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
