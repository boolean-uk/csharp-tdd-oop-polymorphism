using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main.Interfaces
{ 
    public interface IProduct
    {
        string Name { get; set; }
        int Price { get; set; }
        public int getPrice()
        {
            return Price;
        }

        public string getName()
        {
            return Name;
        }
    }
}
