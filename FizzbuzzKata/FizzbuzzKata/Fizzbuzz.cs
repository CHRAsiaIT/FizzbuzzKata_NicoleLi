using System;

namespace FizzbuzzKata
{
    public class Fizzbuzz
    {
        public string FizzbuzzMethod(int enterNumber)
        {
            if (enterNumber % 3 == 0)
                return "Fizz";
            else 
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
