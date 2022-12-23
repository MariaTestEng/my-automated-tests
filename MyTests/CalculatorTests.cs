using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ApplicationToLearnTest;

namespace MyTests
{
    internal class CalculatorTests
    {
        Calculator calculator;
        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void AddTwoPositiveNumbers()
        {
            //act
            var actual = calculator.Add(1, 2);
            var expected = 3;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddTwoNegativeNumbers()
        {
            //act
            var actual = calculator.Add(-1, -2);
            var expected = -3;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddPositiveAndNegativeNumbers()
        {
            //act
            var actual = calculator.Add(200, -300);
            var expected = -100;
            //assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void AddNegativeAndPositiveNumbers()
        {
            //arrange
            var calculator = new Calculator();
            //act
            var actual = calculator.Add(-200, 300);
            var expected = 100;
            //assert
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void SubstructTwoNegativeNumbers()
            //odjac dwie negatywne liczby
        {
            //arrange
            var calculator = new Calculator();
            //act
            var actual = calculator.Substruct(-2, -1);
            var expected = -1;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubstructTwoPositiveNumbers()
        {
            //odejmowanie dwoch dodatnich liczb
            //arrange
            var calculator = new Calculator();
            //act
            var actual = calculator.Substruct(600, 300);
            var expeced = 300;
            //assert
            Assert.AreEqual(expeced, actual);

        }

        [Test]
        public void SubstructNegativeAndPositiveNumbers()
        {
            //odejmowanie ujemnej i dodatniej liczby
            //arrange
            var calculator = new Calculator();
            //act
            var actual = calculator.Substruct(-200, 300);
            var expeced = -500;
            Assert.AreEqual(expeced, actual);
        }

        [Test]
        public void SubstructPositiveAndNegativeNumbers()
        {
            //odejmowanie dodatniej i ujemnej liczby
            //arrange
            var calculator = new Calculator();
            //act
            var actual = calculator.Substruct(200, -300);
            var expected = 500;
            Assert.AreEqual(expected, actual);


        }

        [Test]
        public void MultiplyTwoPositiveNumbers()
            //pomnozyc dwie pozytywne liczby
        {
            //arrange
            var calculator = new Calculator();
            //act
            var actual = calculator.Multiply(1, 2);
            var expected = 2;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MultiplyTwoNegativeNumbers()
        {
            //pomnozenie dwoch ujemnych liczb
            //arrange
            var calculator = new Calculator();
            //act
            var actual = calculator.Multiply(-20, -30);
            var expected = 600;
            //assert
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void MultiplyPositiveAndNegativeNumbers()
        {
            //mnozenie dodatniej i ujemnej liczby
            //arrange
            var calculator = new Calculator();
            //act
            var actual = calculator.Multiply(20, -30);
            var expected = -600;
            //assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void MultiplyNegativeAndPositiveNumbers()
        {
            //mnozenie ujemnej i dodatniej liczby
            //arrange
            var calculator = new Calculator();
            //act
            var actual = calculator.Multiply(-20, 30);
            var expected = -600;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DivideNegativeAndPositiveNumbers()
            //podzielic negatywna i pozytywna liczbe
        {
            //arrange
            var calculator = new Calculator();
            //act
            var actual = calculator.Divide(-56, 8);
            var expected = -7;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DivideTwoPositiveNumbers()
        {
            //podzielenie dwoch dodatnich liczb
            //arrange
            var calculator = new Calculator();
            //act
            var actual = calculator.Divide(50, 10);
            var expected = 5;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DivideTwoNegativeNumbers()
            //dzielenie dwoch ujemnych liczb
        {
            //arrange
            var calculator = new Calculator();
            //act
            var actual = calculator.Divide(-210, -30);
            var expected = 7;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DividedPositiveAndNegativeNumbers()
        {
            //arrange
            var calculator = new Calculator();
            //act
            var actual = calculator.Divide(210, -30);
            var expected = -7;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DividePositiveNumberByZero()
        {
            //arrange
            var calculator = new Calculator();
            //act assert
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));


        }

        [Test]
        public void DivideNegativeNumberByZero()
            //dzielenie ujemnej liczby przez zero
        {
            //arrange
            var calculator = new Calculator();
            //act assert
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(-10, 0));
        }

        [Test]
        public void DivideZeroByZero()
            //dzielenie zero przez zero
        {
            //arrange
            var calculator = new Calculator();
            //act assert
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(0, 0));
        }




    }
}
