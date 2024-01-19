using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        List<IBasketItem> items = new List<IBasketItem>();
       
        public interface IBasketItem
        {
            int GetPrice();
            string GetName();
        }

        public void add(IBasketItem item)
        {
            this.items.Add(item);
        }

        public int getTotal()
        {
            return items.Sum(item => item.GetPrice());
        }

        public bool isInBasket(String name)
        {
            return items.Any(item => item.GetName().Equals(name));
        }

         
        
    }
}
