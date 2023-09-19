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

            Assert.That(basket.isInBasket("Morrowind"), Is.True);
        }

        [Test]
        public void shouldNotFindNonExistingProduct()
        {
            Basket basket = new Basket();
            basket.add(new Game("Morrowind", 12));
            basket.add(new Book("Darkly Dreaming Dexter", 6));
            basket.add(new Drink("Cappucino", 2));

            Assert.That(basket.isInBasket("Skyrim"), Is.False);
        }

        [Test]
        public void shouldReturnZeroIfEmptyBasket()
        {
            Basket basket = new Basket();
            Assert.That(basket.getTotal(), Is.EqualTo(0));
        }

        [Test]
        public void shouldBePossibleToHandleMoreThanOneProductWithTheSameName()
        {
            Basket basket = new Basket();
            basket.add(new Book("Darkly Dreaming Dexter", 8));
            basket.add(new Book("Darkly Dreaming Dexter", 14));
            Assert.That(basket.getTotal(), Is.EqualTo(22));
            Assert.That(basket.isInBasket("Darkly Dreaming Dexter"), Is.True);
        }

        [Test]
        public void shouldHandleCaseSensitivityInTheBasket()
        {
            Basket basket = new Basket();
            basket.add(new Game("Morrowind", 15));
            Assert.That(basket.isInBasket("Morrowind"), Is.True);
            Assert.That(basket.isInBasket("morrowind"), Is.True);
        }

        [Test]
        public void shouldRemoveTheProduct()
        {
            Basket basket = new Basket();
            Game game = new Game("Morrowind", 12);
            basket.add(game);
            basket.remove(game);
            Assert.That(basket.getTotal(), Is.EqualTo(0));
            Assert.That(basket.isInBasket("Morrowind"), Is.False);
        }
    }
}