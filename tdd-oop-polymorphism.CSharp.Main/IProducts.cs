using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public interface IProducts
{
        string name { get { return name; } }
        int price { get { return price; } }

        public int getPrice();
        public string getName();

}
}
