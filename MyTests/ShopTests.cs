using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ApplicationToLearnTest;

namespace MyTests
{
    internal class ShopTests
    {
        Shop shop;
        [SetUp]
        public void Setup()
        {
            shop = new Shop();
        }

        [Test]
        public void CheckDiscountForNine()
            //sprawdz znizke na 9
        {
            //act
            var actual = shop.CreateDiscount(3, 9);
            var expected = 0;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDiscountForTen()
        {
            //act
            var actual = shop.CreateDiscount(5, 10);
            var expected = 0.5;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDoscountForTwentyNine()
        {
            //act
            var actual = shop.CreateDiscount(5, 29);
            var expected = 0.5;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDiscountForThirty()
        {
            //act
            var actual = shop.CreateDiscount(3, 30);
            var expected = 5.45;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDiscountFortyNine()
        {
            //act
            var actual = shop.CreateDiscount(3, 49);
            var espected = 5.45;
            //assert
            Assert.AreEqual(espected, actual);
        }

        [Test]
        public void CheckDiscountForFifty()
        {
            //act
            var actual = shop.CreateDiscount(3, 50);
            var expected = 10.6;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDiscountForNinetyNine()
        {
            //act
            var actual = shop.CreateDiscount(3, 99);
            var expected = 10.6;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDiscountForNegativeQuantity()
            //sprawdz rabat dla ilosci ujemnej
        {
            //act assert
            Assert.Throws<Exception>(()=>shop.CreateDiscount(-3, 9));
        }

        [Test]
        public void CheckDiscountForNegativePrice()
            //sprawdz rabat dla ceny ujemnej
        {
            //act. assert
            Assert.Throws<Exception>(() => shop.CreateDiscount(3, -20));
        }

        [Test]
        public void CheckDiscountForZeroQuantity()
            //sprawdz rabat dla ilosci zerowej
        {
            //act. assert
            Assert.Throws<Exception>(() => shop.CreateDiscount(0, 40));
        }

        [Test]
        public void CheckDiscountForZeroPrice()
            //sprawdz rabat za cene zerowa
        {
            //act. assert
            Assert.Throws<Exception>(() => shop.CreateDiscount(3, 0));
        }
    }
}
