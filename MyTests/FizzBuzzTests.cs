using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ApplicationToLearnTest;
using System.Security.Cryptography.X509Certificates;

namespace MyTests
{
    internal class FizzBuzzTests
    {
        FizzBuzz fizzBuzz;

        [SetUp]
        public void Setup()
        {
            fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void CheckIfDividePositiveNumberByFive()
            //sprawdz czy podzieli liczbe dodatnia przez piec
        {
            //act
            var actual = fizzBuzz.CheckFizzBuzz(25);
            var expected = "Buzz";
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckIfDivideNegativeNumberByFive()
        {
            //act
            var actual = fizzBuzz.CheckFizzBuzz(-55);
            var expected = "Buzz";
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckIfDivideNegativeNumberByThreeAndFive()
        {
            //act
            var actual = fizzBuzz.CheckFizzBuzz(-30);
            var expected = "FizzBuzz";
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckIfDividePositiveNumberByThreeAndFive()
            {
                //act
                var actual = fizzBuzz.CheckFizzBuzz(30);
                var expected = "FizzBuzz";
                //assert
                Assert.AreEqual(expected, actual);
            }


        [Test]
        public void CheckIfNotDividePositiveNumberByThreeAndFive()
            //sprawdz czy nie podzieli liczby dodatniej przez trzy i piec
        {
            //act assert
            Assert.Throws<Exception>(() => fizzBuzz.CheckFizzBuzz(19));
        }

            [Test]
            public void CheckIfNotDivideNegativeNumberByThreeAndFive()
            {
                //act assert
                Assert.Throws<Exception>(() => fizzBuzz.CheckFizzBuzz(-16));
            }

        [Test]
        public void CheckIfDividePositiveNumberByThree()
        {
            //act
            var actual = fizzBuzz.CheckFizzBuzz(9);
            var expected = "Fizz";
            //assert
            Assert.AreEqual(expected, actual);
        }

            [Test]
            public void CheckIfDivideNegativeNumberByThree()
            {
                //act
                var actual = fizzBuzz.CheckFizzBuzz(-12);
                var expected = "Fizz";
                //assert
                Assert.AreEqual(expected, actual);
            }




    }
}
