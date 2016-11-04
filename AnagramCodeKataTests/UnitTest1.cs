using System;
using AnagramCodeKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnagramCodeKataTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_two_strings_that_are_anagrams_then_returns_true()
        {
            var stringOne = "pot";
            var stringTwo = "top";

            var isAnagram = stringOne.IsAnagramOf(stringTwo);

            Assert.IsTrue(isAnagram);
        }
    }
}