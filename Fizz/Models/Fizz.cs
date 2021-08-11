using System;

//If number is divisble by 3 print Fizz ,
//if number is divisible by 5 print buzz.
//int, non-negative int. 
namespace Fizz
{
    public class FizzBuzz
    {
        public static string[] GenerateFizzBuzz(int n, int fizz = 3, int buzz = 5)
        {
            string[] fizzBuzzArray = new string[n];
            // for loop with i correlating with each integer between 0 and n;
            for (int i = 0; i < n; i++)
            {
                int number = i + 1;
                if(number % buzz == 0 && number % fizz == 0)
                {
                    fizzBuzzArray[i] = "FizzBuzz";
                } 
                else if (number % fizz == 0)
                {
                    fizzBuzzArray[i] = "Fizz";
                }
                else if (number % buzz == 0)
                {
                    fizzBuzzArray[i] = "Buzz";
                }
                else
                {
                    string parsedNumber = number.ToString();
                    fizzBuzzArray[i] = parsedNumber;
                }
                //check for integers that are divisible by 3
                // check for integers that are divisible by 5
                // if integers are divisible by 5 AND 3, print "FizzBuzz"
            }
            return fizzBuzzArray;
        }
    }
}