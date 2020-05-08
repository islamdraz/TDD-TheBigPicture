﻿namespace TDD.Dll
{
    public class FizzBuzzService
    {

        public string Print(int n)
        {
            if (n % 5 == 0&&n%3==0)
            {
                return "FizzBuzz";
            }
            if (n % 5 == 0)
            {
                return "Buzz";
            }
            if (n % 3 == 0)
            {
                return "Fizz";
            }
            return n.ToString();
        }
    }
}
