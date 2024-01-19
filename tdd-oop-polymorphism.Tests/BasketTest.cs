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
            basket.add(new Game() { name = "Morrowind", price = 12 });
            basket.add(new Book() { name = "Darkly Dreaming Dexter", price = 6 });
            basket.add(new Drink() { name = "Cappucino", price = 2 });

            Assert.AreEqual(20, basket.getTotal());
        }

        [Test]
        public void shouldFindExistingProduct()
        {
            Basket basket = new Basket();
            basket.add(new Game() { name = "Morrowind", price = 12 });
            basket.add(new Book() { name = "Darkly Dreaming Dexter", price = 6 });
            basket.add(new Drink() { name = "Cappucino", price = 2 });

            Assert.IsTrue(basket.isInBasket("Morrowind"));
        }

        [Test]
        public void shouldNotFindNonExistingProduct()
        {
            Basket basket = new Basket();
            basket.add(new Game() { name = "Morrowind", price = 12 });
            basket.add(new Book() { name = "Darkly Dreaming Dexter", price = 6 });
            basket.add(new Drink() { name = "Cappucino", price = 2 });

            Assert.IsFalse(basket.isInBasket("Skyrim"));
        }
    }
}