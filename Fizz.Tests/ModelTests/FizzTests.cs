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
        [TestMethod]
        public void GenereateFizzBuzz_FiveDivisibles_Buzz()
        {
            int testNumber = 5;
            string[] testArray = FizzBuzz.GenerateFizzBuzz(testNumber);
            Assert.AreEqual("Buzz", testArray[testNumber - 1]);
        }
        [TestMethod]
        public void GenerateFizzBuzz_ThreeDivisibles_Fizz()
        {
            int testNumber = 3;
            string[] testArray = FizzBuzz.GenerateFizzBuzz(testNumber);
            Assert.AreEqual("Fizz", testArray[testNumber - 1]);
        }
        [TestMethod]
        public void GenerateFizzBuzz_CollectionsAreEqual_Array()
        {
            int testNumber = 5;
            string[] arraySolution = { "1", "2", "Fizz", "4", "Buzz" };
            string[] testArray = FizzBuzz.GenerateFizzBuzz(5);
            CollectionAssert.AreEqual(arraySolution, testArray);
        }
    }
}