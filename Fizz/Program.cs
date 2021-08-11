using System;

//If number is divisble by 3 print Fizz ,
//if number is divisible by 5 print buzz.
//int, non-negative int. 
// make application distributed individually ( apart from console application)
// unit testing, for 3 and 5 case
// Any additional unit testing needed
// Create ability to redefine pairs of numbers, including unit testing


namespace Fizz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzzInstance = new FizzBuzz();
            int testNumber = 100;
            string[] fizzBuzzArray = fizzBuzzInstance.GenerateFizzBuzz(testNumber);
            for (int i = 0; i < testNumber; i ++)
            {
                Console.WriteLine(fizzBuzzArray[i]);
            }
        }
    }
}
