using System;

namespace OnlineCalculator.Services
{
    public class CalculatorService
    {
        public bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        public bool IsDivisor(int dividend, int divisor)
        {
            return dividend % divisor == 0;
        }
    }

}
