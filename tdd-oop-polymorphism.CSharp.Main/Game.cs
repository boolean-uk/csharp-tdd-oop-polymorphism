namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Game : IItem
    {
        string name;
        int price;

        public Game(string name, int price)
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
