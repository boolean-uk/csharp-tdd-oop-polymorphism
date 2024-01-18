

public class Item {
    public string name;
    public int price;

    public Item(string name, int price) {
        this.name = name;
        this.price = price;
    }

    public int getPrice()
    {
        return this.price;
    }

    public string getName()
    {
        return this.name;
    }
}