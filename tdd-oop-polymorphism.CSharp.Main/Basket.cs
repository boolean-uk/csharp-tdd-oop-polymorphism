namespace tdd_oop_polymorphism.CSharp.Main;

public class Basket
{
    List<IProduct> _products = new List<IProduct>();

    public void add(IProduct product)
    {
        _products.Add(product);
    }

    public int getTotal()
    {
        int total = 0;

        foreach (IProduct item in _products)
        {
            total += item.getPrice();
        }

        return total;
    }

    public bool isInBasket(String name)
    {
        foreach (IProduct item in _products)
        {
            if (item.getName().Equals(name))
            {
                return true;
            }
        }

        return false;
    }
}
