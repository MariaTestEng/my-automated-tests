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
        public void CheckCreateCalculator()
        {
            var calculator=new CalculatorClass();
            //Assert
            Assert.IsInstanceOf<CalculatorClass>(calculator);
        }
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
        public void AddTwoNegativeNumbers()
        {
            //arrange
            var calculator = new CalculatorClass()
            {
                Number1 = -1,
                Number2 = -2
            };
            //act
            var actual = calculator.Add();
            var expected = -3;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddPositiveAndNegativeNumbers()
        {
            //arrange
            var calculator = new CalculatorClass()
            {
                Number1 = 200,
                Number2 = -300
            };
            //act
            var actual = calculator.Add();
            var expected = -100;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddNegativeAndPositiveNumbers()
        {
            //arrange
            var calculator = new CalculatorClass()
            {
                Number1 = -200,
                Number2 = 300
            };
            //act
            var actual = calculator.Add();
            var expected = 100;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubstructTwoNegativeNumbers()
        {
            //arrange
            var calculator = new CalculatorClass()
            {
                Number1 = -2,
                Number2 = -1
            };
            //act
            var actual = calculator.Substruct();
            var expected = -1;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubstructTwoPositiveNumbers()
        {
            //arrange
            var calculator = new CalculatorClass()
            {
                Number1 = 600,
                Number2 = 300
            };
            //act
            var actual = calculator.Substruct();
            var expected =300;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubstructNegativeAndPositiveNumbers()
        {
            //arrange
            var calculator = new CalculatorClass()
            {
                Number1 = -200,
                Number2 = 300
            };
            //act
            var actual = calculator.Substruct();
            var expected = -500;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubstructPositiveAndNegativeNumbers()
        {
            //arrange
            var calculator = new CalculatorClass()
            {
                Number1 = 200,
                Number2 = -300
            };
            //act
            var actual = calculator.Substruct();
            var expected = 500;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MultiplyTwoPositiveNumbers()
        {
            //arrange
            var calculator = new CalculatorClass()
            {
                Number1 = 1,
                Number2 = 2
            };
            //act
            var actual = calculator.Multiply();
            var expected = 2;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MultiplyTwoNegativeNumbers()
        {
            //arrange
            var calculator = new CalculatorClass()
            {
                Number1 = -20,
                Number2 = -30
            };
            //act
            var actual = calculator.Multiply();
            var expected = 600;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MultiplyPositiveAndNegativeNumbers()
        {
            //arrange
            var calculator = new CalculatorClass()
            {
                Number1 = 20,
                Number2 = -30
            };
            //act
            var actual = calculator.Multiply();
            var expected = -600;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MultiplyNegativeAndPositiveNumbers()
        {
            //arrange
            var calculator = new CalculatorClass()
            {
                Number1 = -20,
                Number2 = 30
            };
            //act
            var actual = calculator.Multiply();
            var expected = -600;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DivideTwoPositiveNumbers()
        {
            //arrange
            var calculator = new CalculatorClass()
            {
                Number1 = 50,
                Number2 = 10
            };
            //act
            var actual = calculator.Divide();
            var expected = 5;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DivideTwoNegativeNumbers()
        {
            //arrange
            var calculator = new CalculatorClass()
            {
                Number1 = -210,
                Number2 = -30
            };
            //act
            var actual = calculator.Divide();
            var expected = 7;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DivideNegativeAndPositiveNumbers()
        {
            //arrange
            var calculator = new CalculatorClass()
            {
                Number1 = -50,
                Number2 = 8
            };
            //act
            var actual = calculator.Divide();
            var expected = -6;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DividePositiveAndNegativeNumbers()
        {
            //arrange
            var calculator = new CalculatorClass()
            {
                Number1 = 210,
                Number2 = -30
            };
            //act
            var actual = calculator.Divide();
            var expected = -7;
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

        [Test]
        public void DivideNegativeNumberByZero()
        //podzielic liczbe dodatnia przez zero
        {
            //arrange
            var calculator = new CalculatorClass()
            {
                Number1 = -10,
                Number2 = 0
            };
            //assert act
            Assert.Throws<DivideByZeroException>(() => calculator.Divide());
        }


    }
}


