using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ApplicationToLearnTest;

namespace MyTests
{
    internal class CalculatorClassTests
    {
        [Test]
        public void AddTwoPositiveNumbers()
            //dodac dwie pozytywne liczby
        {
            //arrange
            var calculator = new CalculatorClass()
            {
                Number1 = 2,
                Number2 = 2
            };
            //act
            var actual = calculator.Add();
            var expected = 4;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DividePositiveNumberByZero()
            //podzielic liczbe dodatnia przez zero
        {
            //arrange
            var calculator = new CalculatorClass()
            {
                Number1 = 20,
                Number2 = 0
            };
            //assert act
            Assert.Throws<DivideByZeroException>(() => calculator.Divide());
        }


    }
}


