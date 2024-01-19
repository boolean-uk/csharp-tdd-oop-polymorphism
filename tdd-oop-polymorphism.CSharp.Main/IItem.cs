using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public interface IItem
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public int getPrice()
        {
            return this.Price;
        }

        public string getName()
        {
            return this.Name;
        }
    }
}
