namespace Fizz
{
    public class FizzBuzz
    {
        public static string[] GenerateFizzBuzz(int n, int fizz = 3, int buzz = 5)
        {
            string[] fizzBuzzArray = new string[n];
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
            }
            return fizzBuzzArray;
        }
    }
}