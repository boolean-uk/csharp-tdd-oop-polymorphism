﻿namespace tdd_oop_polymorphism.CSharp.Main;

public class Game : IProduct
{
    string name;
    int price;

    public Game(string name, int price)
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
