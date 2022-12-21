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
        public void CheckDiscontForNegativePrice()
        {
            //arrange
            var shopClass=new ShopClass(3, -1);
            //act assert
            Assert.Throws<Exception>(()=> shopClass.CreateDiscount());
        }
    }
}
