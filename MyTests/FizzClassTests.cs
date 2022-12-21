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
        public void CheckNotDivideNegativeNumberByThreeAndFive()
        {
            //arrange
            var fizzClass=new FizzClass(-14);
            //act assert
            Assert.Throws<Exception>(()=>fizzClass.CheckFizzBuzz());
            
        }
    }
}
