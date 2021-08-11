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
            FizzBuzz.GenerateFizzBuzz(3);
        }
    }
}