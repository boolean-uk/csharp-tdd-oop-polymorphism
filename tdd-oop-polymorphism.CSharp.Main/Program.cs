// See https://aka.ms/new-console-template for more information
using tdd_oop_polymorphism.CSharp.Main;

Console.WriteLine("Hello, World!");


Basket basket = new Basket();
basket.add(new Game() { name = "Morrowind", price = 12 });
basket.add(new Book() { name = "Darkly Dreaming Dexter", price = 6 });
basket.add(new Drink() { name = "Cappucino", price = 2 });
Console.WriteLine(basket.getTotal());