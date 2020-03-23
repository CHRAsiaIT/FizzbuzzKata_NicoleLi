using System;

namespace FizzbuzzKata
{
    public class Fizzbuzz
    {
        public string FizzbuzzMethod(int enterNumber)
        {
            if (enterNumber % 15 == 0)
                return "FizzBuzz";
            if (enterNumber % 3 == 0)
                return "Fizz";
            if (enterNumber % 5 == 0)
                return "Buzz";
            return enterNumber.ToString();
        }

        static void Main(string[] args)
        {
            Fizzbuzz _fizzbuzz = new Fizzbuzz();
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(_fizzbuzz.FizzbuzzMethod(i));
            }
        }
    }
}
