using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ApplicationToLearnTest;

namespace MyTests
{
    internal class FizzClassTests
    {
        [Test]
        public void CheckDividePositiveNumberByThreeAndFive()
        {
            //arrange
            var fizzClass = new FizzClass(15);
            //act
            var actual = fizzClass.CheckFizzBuzz();
            var expected ="FizzBuzz";
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDivideNegativeNumberByThreeAndFive()
        {
            //arrange
            var fizzClass = new FizzClass(-15);
            //act
            var actual = fizzClass.CheckFizzBuzz();
            var expected = "FizzBuzz";
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDividePositiveNumberByFive()
        {
            //arrange
            var fizzClass = new FizzClass(10);
            //act
            var actual = fizzClass.CheckFizzBuzz();
            var expected = "Buzz";
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDividePositiveNumberByThree()
        {
            //arrange
            var fizzClass = new FizzClass(9);
            //act
            var actual = fizzClass.CheckFizzBuzz();
            var expected = "Fizz";
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDivideNegativeNumberByThree()
        {
            //arrange
            var fizzClass = new FizzClass(-9);
            //act
            var actual = fizzClass.CheckFizzBuzz();
            var expected = "Fizz";
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckDivideNegativeNumberByFive()
        {
            //arrange
            var fizzClass = new FizzClass(-10);
            //act
            var actual = fizzClass.CheckFizzBuzz();
            var expected = "Buzz";
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckNotDivideNegativeNumberByThreeAndFive()
        {
            //arrange
            var fizzClass=new FizzClass(-14);
            //act assert
            Assert.Throws<Exception>(()=>fizzClass.CheckFizzBuzz());  
        }

        [Test]
        public void CheckNotDividePositiveNumberByThreeAndFive()
        {
            //arrange
            var fizzClass = new FizzClass(16);
            //act assert
            Assert.Throws<Exception>(() => fizzClass.CheckFizzBuzz());
        }
    }
}
