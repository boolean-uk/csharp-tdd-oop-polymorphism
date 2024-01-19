using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        List<Product> products = new List<Product>();

        public void Add(Product product)
        {
            this.products.Add(product);
        }
        public int GetTotalPrice()
        {
            return products.Sum(x => x.GetPrice());
        }

        public bool IsInBasket(String name)
        {
            Product p = products.Find(x => x.GetName() == name);

            if( p == default(Product) || p == null)
                return false;

            return true;
        }
    }
}
