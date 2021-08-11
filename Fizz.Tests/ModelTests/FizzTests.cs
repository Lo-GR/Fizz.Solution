using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Fizz;

namespace Fizz.Tests
{
    [TestClass]
    public class FizzTests
    {

        [TestMethod]
        public void GenerateFizzBuzz_FifteenDivisibles_FizzBuzz()
        {
            int testNumber = 15;
            string[] testArray = FizzBuzz.GenerateFizzBuzz(testNumber);
            Assert.AreEqual("FizzBuzz", testArray[testNumber - 1]);
        }
    }
}