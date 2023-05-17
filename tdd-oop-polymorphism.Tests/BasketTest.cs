using NUnit.Framework;
using tdd_oop_polymorphism.CSharp.Main;

namespace tdd_oop_polymorphism.Tests
{
    class BasketTest
    {
        [Test]
        public void shouldCalculateTotal()
        {
            Basket basket = new Basket();
            Book book = new Book();
            Drink drink = new Drink();
            Game game = new Game();
            game.name = "Morrowind";
            game.price = 12;
            book.name = "Darkly Dreaming Dexter";
            book.price = 6;
            drink.name = "Cappucino";
            drink.price = 2;
            basket.add(book);
            basket.add(drink);
            basket.add(game);

            Assert.AreEqual(20, basket.getTotal());
        }

        [Test]
        public void shouldFindExistingProduct()
        {
            Basket basket = new Basket();
            Book book = new Book();
            Drink drink = new Drink();
            Game game = new Game();
            game.name = "Morrowind";
            game.price = 12;
            book.name = "Darkly Dreaming Dexter";
            book.price = 6;
            drink.name = "Cappucino";
            drink.price = 2;
            basket.add(book);
            basket.add(drink);
            basket.add(game);

            Assert.IsTrue(basket.isInBasket("Morrowind"));
        }

        [Test]
        public void shouldNotFindNonExistingProduct()
        {
            Basket basket = new Basket();
            Book book = new Book();
            Drink drink = new Drink();
            Game game = new Game();
            game.name = "Morrowind";
            game.price = 12;
            book.name = "Darkly Dreaming Dexter";
            book.price = 6;
            drink.name = "Cappucino";
            drink.price = 2;
            basket.add(book);
            basket.add(drink);
            basket.add(game);

            Assert.IsFalse(basket.isInBasket("Skyrim"));
        }
    }
}