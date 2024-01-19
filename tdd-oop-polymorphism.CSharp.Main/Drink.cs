namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Drink : IItem
    {
        string name;
        int price;

        public Drink(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public int GetPrice()
        {
            return this.price;
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
