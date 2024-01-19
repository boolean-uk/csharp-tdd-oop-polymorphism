using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        List<IObject> _objList = new List<IObject>();


        public void add(IObject inputObject)
        {
            this._objList.Add(inputObject);
        }



        public int getTotal()
        {
            int total = 0;

            foreach (IObject obj in this._objList)
            {
                total += obj.price;
            }

            return total;
        }

        public bool isInBasket(String name)
        {
            foreach (IObject obj in this._objList)
            {
                if (obj.name.Equals(name))
                {
                    return true;
                }
            }

         

            return false;
        }
    }
}
