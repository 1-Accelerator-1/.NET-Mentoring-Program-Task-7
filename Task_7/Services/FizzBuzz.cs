using Task_7.Services.Interfaces;
using Task_7.ValidationExceptions;

namespace Task_7.Services
{
    internal class FizzBuzz : IFizzBuzz
    {
        public string ConvertNumberToString(int number)
        {
            if (number < 1 || number > 100)
            {
                throw new NumberOutOfRangeException("The number out of range (1 - 100).");
            }

            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }

            if (number % 3 == 0)
            {
                return "Fizz";
            }

            if (number % 5 == 0)
            {
                return "Buzz";
            }

            return number.ToString();
        }
    }
}
