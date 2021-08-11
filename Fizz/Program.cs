using System;

namespace Fizz
{
    public class Program
    {
        static void Main()
        {
            int testNumber = 100;
            string[] fizzBuzzArray = FizzBuzz.GenerateFizzBuzz(testNumber);
            for (int i = 0; i < testNumber; i ++)
            {
                Console.WriteLine(fizzBuzzArray[i]);
            }
        }
    }
}
