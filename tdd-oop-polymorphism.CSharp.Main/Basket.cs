namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        List<Item> items = new List<Item>();

        public void add(Item item)
        {
            this.items.Add(item);
        }

        public int getTotal()
        {
            int total = 0;

            foreach (Item item in this.items)
            {
                total += item.getPrice();
            }

            return total;
        }

        public bool isInBasket(String name)
        {
            foreach (var item in this.items)
            {
                if (item.getName().Equals(name))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
