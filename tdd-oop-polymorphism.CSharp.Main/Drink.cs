namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Drink : Item
    {
        //string name;
        //int price;

        public Drink(string name, int price)
        {
            base.Name = name;
            base.Price = price;
        }

        /*
        public int getPrice()
        {
            return this.price;
        }

        public string getName()
        {
            return this.name;
        }
        */
    }
}
