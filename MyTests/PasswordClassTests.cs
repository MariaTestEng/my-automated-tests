using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ApplicationToLearnTest;

namespace MyTests
{
    internal class PasswordClassTests
    {
        [Test]
        public void  CheckCorrectPassword()
        {
            //arrange
            var password = new PasswordClass()
            {
                MyPassword = "Majkae1@"
            };
            //act
            var actual=password.CheckPassword();
            //assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void CheckPasswordWithoutSpecjalCharacters()
        {
            //arrange
            var password = new PasswordClass()
            {
                MyPassword = "Majkaeb1"
            };
            //act
            var actual = password.CheckPassword();
            //assert
            Assert.IsFalse(actual);
        }


        [Test]
        public void CheckPasswordTooShort()
        {
            //arrange
            var password = new PasswordClass()
            {
                MyPassword = "Majka1@"
            };
            //act
            var actual = password.CheckPassword();
            //assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void CheckPasswordSmallLetters()
        {
            //arrange
            var password = new PasswordClass()
            {
                MyPassword = "majkaeb@"
            };
            //act
            var actual = password.CheckPassword();
            //assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void CheckPasswordWithoutNumber()
        {
            //arrange
            var password = new PasswordClass()
            {
                MyPassword = "Majkaeb@"
            };
            //act
            var actual = password.CheckPassword();
            //assert
            Assert.IsFalse(actual);
        }
        
    }
}
