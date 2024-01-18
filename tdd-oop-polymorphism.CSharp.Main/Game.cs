namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Game : Item
    {
        /*
        string name;
        int price;

        public Game(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        */

        public Game(string name, int price)
        {
            base.Name = name;
            base.Price = price;
        }

        /*
        public int getPrice()
        {
            return base.Price;
        }

        public string getName()
        {
            return base.Name;
        }
        */
    }
}
