using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ApplicationToLearnTest;

namespace MyTests
{
    internal class ShopClassTests
    {
        [Test]
        public void CheckDiscontForNine()
        {
            //arrange
            var shopClass = new ShopClass(3, 9);
            //act
            var actual = shopClass.CreateDiscount();
            var expected = 0;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDiscontForTen()
        {
            //arrange
            var shopClass = new ShopClass(5, 10);
            //act
            var actual = shopClass.CreateDiscount();
            var expected = 0.5;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDiscontForTwentyNine()
        {
            //arrange
            var shopClass = new ShopClass(5, 29);
            //act
            var actual = shopClass.CreateDiscount();
            var expected = 0.5;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDiscontForThirty()
        {
            //arrange
            var shopClass = new ShopClass(3, 30);
            //act
            var actual = shopClass.CreateDiscount();
            var expected = 5.45;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDiscontForFortyNine()
        {
            //arrange
            var shopClass = new ShopClass(3, 49);
            //act
            var actual = shopClass.CreateDiscount();
            var expected = 5.45;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDiscontForFifty()
        {
            //arrange
            var shopClass = new ShopClass(3, 50);
            //act
            var actual = shopClass.CreateDiscount();
            var expected = 10.6;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDiscontForNinetyNine()
        {
            //arrange
            var shopClass = new ShopClass(3, 99);
            //act
            var actual = shopClass.CreateDiscount();
            var expected = 10.6;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDiscontForNegativeQuantity()
        {
            //arrange
            var shopClass = new ShopClass(-9, 3);
            //act assert
            Assert.Throws<Exception>(() => shopClass.CreateDiscount());
        }


        [Test]
        public void CheckDiscontForNegativePrice()
        {
            //arrange
            var shopClass=new ShopClass(3, -1);
            //act assert
            Assert.Throws<Exception>(()=> shopClass.CreateDiscount());
        }
    }
}
