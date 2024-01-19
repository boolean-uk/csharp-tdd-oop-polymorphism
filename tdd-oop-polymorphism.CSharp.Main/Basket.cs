namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        List<IItem> items = new();

        public void Add(IItem item)
        {
            this.items.Add(item);
        }

        public int GetTotal()
        {
            int total = 0;

            foreach (IItem item in this.items)
            {
                total += item.GetPrice();
            }
            return total;
        }

        public bool IsInBasket(String name)
        {
            foreach (IItem item in this.items)
            {
                if (item.GetName().Equals(name))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
