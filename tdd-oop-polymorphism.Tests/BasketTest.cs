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
            basket.add(new Game("Morrowind", 12));
            basket.add(new Book("Darkly Dreaming Dexter", 6));
            basket.add(new Drink("Cappucino", 2));

            Assert.That(basket.getTotal(), Is.EqualTo(20));
        }

        [Test]
        public void shouldFindExistingProduct()
        {
            Basket basket = new Basket();
            basket.add(new Game("Morrowind", 12));
            basket.add(new Book("Darkly Dreaming Dexter", 6));
            basket.add(new Drink("Cappucino", 2));

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