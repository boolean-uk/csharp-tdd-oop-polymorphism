using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products;
using tdd_oop_polymorphism.CSharp.Main.Interfaces;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        List<IProduct> products = new List<IProduct>();


        public void add(IProduct product)
        {
            this.products.Add(product);
        }


        public int getTotal()
        {
            return products.Sum(x => x.GetPrice());
        }

        public bool isInBasket(string name)
        {
            return products.Any(product => product.GetName().Equals(name));
        }
    }
}
