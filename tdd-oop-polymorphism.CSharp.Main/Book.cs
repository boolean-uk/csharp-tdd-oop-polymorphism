namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Book : Item
    {
        //string name;
        //int price;

        public Book(string name, int price)
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
