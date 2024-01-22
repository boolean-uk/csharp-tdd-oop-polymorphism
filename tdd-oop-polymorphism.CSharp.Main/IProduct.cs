using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    //IProduct interface declares properties for the name and price of a product.
    public interface IProduct
    {
        string Name { get; set; }
        int Price { get; set; }
    }
}
