using Interfaces;
using NUnit.Framework;
using Products;
using tdd_oop_polymorphism.CSharp.Main;

namespace tdd_oop_polymorphism.Tests
{
    class BasketTest
    {
        [Test]
        public void shouldCalculateTotal()
        {
            IProduct game = new Game("Morrowind", 12);
            IProduct book = new Game("Darkly Dreaming Dexter", 6);
            IProduct drink = new Game("Cappucino", 2);

            Basket basket = new Basket();
            basket.add(game);
            basket.add(book);
            basket.add(drink);

            Assert.AreEqual(20, basket.getTotal());
        }

        [Test]
        public void shouldFindExistingProduct()
        {
            IProduct game = new Game("Morrowind", 12);
            IProduct book = new Game("Darkly Dreaming Dexter", 6);
            IProduct drink = new Game("Cappucino", 2);

            Basket basket = new Basket();
            basket.add(game);
            basket.add(book);
            basket.add(drink);

            Assert.IsTrue(basket.isInBasket("Morrowind"));
        }

        [Test]
        public void shouldNotFindNonExistingProduct()
        {
            Basket basket = new Basket();
            basket.add(new Game("Morrowind", 12));
            basket.add(new Book("Darkly Dreaming Dexter", 6));
            basket.add(new Drink("Cappucino", 2));

            Assert.IsFalse(basket.isInBasket("Skyrim"));
        }
    }
}