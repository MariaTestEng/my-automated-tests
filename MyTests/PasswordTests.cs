using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ApplicationToLearnTest;

namespace MyTests
{
    internal class PasswordTests
    {
        Password password;
        [SetUp]
        public void Setup()
        {
            password = new Password();
        }

        [Test]
        public void CheckCorrectPassword()
            //sprawdz poprawnosc hasla
        {
            //act
            var actual = password.CheckPassword("MajkaE1@");
            //assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void CheckPasswordWithoutBigLetters()
        {
            //act
            var actual = password.CheckPassword("majkae1@");
            //assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void CheckPasswordWithoutNumbers()
        {
            //act
            var actual = password.CheckPassword("Majkaeb@");
            //assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void CheckPasswordWithoutSpecialCharacters()
        {
            //act
            var actual = password.CheckPassword("Majkaeb1");
            //assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void CheckPasswordTooShort()
        {
            //act
            var actual = password.CheckPassword("Majka1@");
            //assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void CheckPasswordSmallLetters()
        {
            //act
            var actual = password.CheckPassword("majkae1@");
            //assert
            Assert.IsFalse(actual);
        }



    }
}
