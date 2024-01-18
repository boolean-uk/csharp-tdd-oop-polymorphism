namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Item
    {
        public string Name { get; set; }
        public int Price { get; set; }

        /*
        public Item(string name, int price)
        {
            Name = name;
            Price = price;
        }
        */

        public int getPrice()
        {
            return this.Price;
        }

        public string getName()
        {
            return this.Name;
        }
    }
}
