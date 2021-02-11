using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generate a random number between 1 and 100
            Random rand = new Random();
            int randNum = rand.Next(1, 101);
            int divisibleBy3Remainder = randNum % 3;
            bool isDivisibleBy3 = divisibleBy3Remainder % 3 == 0;

            //randNum = 20;
            if (randNum % 3 == 0 && randNum % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if (randNum % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (randNum % 3 == 0) // == true)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine(randNum);
            }
        }
    }
}
