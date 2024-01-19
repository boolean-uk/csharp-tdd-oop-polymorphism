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
            basket.Add(new Game("Morrowind", 12));
            basket.Add(new Book("Darkly Dreaming Dexter", 6));
            basket.Add(new Drink("Cappucino", 2));

            Assert.AreEqual(20, basket.GetTotal());
        }

        [Test]
        public void shouldFindExistingProduct()
        {
            Basket basket = new Basket();
            basket.Add(new Game("Morrowind", 12));
            basket.Add(new Book("Darkly Dreaming Dexter", 6));
            basket.Add(new Drink("Cappucino", 2));

            Assert.IsTrue(basket.IsInBasket("Morrowind"));
        }

        [Test]
        public void shouldNotFindNonExistingProduct()
        {
            Basket basket = new Basket();
            basket.Add(new Game("Morrowind", 12));
            basket.Add(new Book("Darkly Dreaming Dexter", 6));
            basket.Add(new Drink("Cappucino", 2));

            Assert.IsFalse(basket.IsInBasket("Skyrim"));
        }
    }
}