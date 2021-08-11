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
            string[] testArray = FizzBuzz.GenerateFizzBuzz(testNumber);
            CollectionAssert.AreEqual(arraySolution, testArray);
        }
        [TestMethod]
        public void GenerateFizzBuzz_Overload5and3_Array()
        {
            int arrayLength = 14;
            int replaceFizz = 2;
            int replaceBuzz = 7;
            string[] arraySolution = { "1", "Fizz", "3", "Fizz", "5", "Fizz", "Buzz", "Fizz", "9", "Fizz", "11", "Fizz", "13", "FizzBuzz" };
            string[] testArray = FizzBuzz.GenerateFizzBuzz(arrayLength, replaceFizz, replaceBuzz);
            CollectionAssert.AreEqual(arraySolution, testArray);
        }
    }
}