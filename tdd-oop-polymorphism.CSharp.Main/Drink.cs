﻿namespace tdd_oop_polymorphism.CSharp.Main;

public class Drink : IProduct
{
    string name;
    int price;

    public Drink(string name, int price)
    {
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
