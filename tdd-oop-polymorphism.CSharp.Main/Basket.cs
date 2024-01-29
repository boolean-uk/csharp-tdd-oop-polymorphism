using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        private List<IProduct> products = new List<IProduct>();

        public List<IProduct> Products { get { return products; } }

        public void add(IProduct product)
        {
            this.products.Add(product);
        }

       
        public int getTotal()
        {
            int total = Products.Sum(x => x.Price);

            return total;
        }

        public bool isInBasket(String name)
        {
            if(!Products.Any(x => x.Name == name)) return false;

            return true;
        }
    }
}
