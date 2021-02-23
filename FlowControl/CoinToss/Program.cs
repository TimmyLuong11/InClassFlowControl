using System;

namespace CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring Variables 
            const string developer = "Timmy Luong";
            string ans;
            int randomNum, coin;
            int guess = 0;
            Random rand;

            //Output to console to gather user information
            Console.WriteLine("Please pick heads or tails >>");
            ans = Console.ReadLine().ToLower();

            //Generating a random number between 1 and 2
            rand = new Random();
            randomNum = rand.Next(1,3); 

            //Assigning a value if the input is head or tails
            if (ans == "heads")
            {
                guess = 1;
            }
            else //if (ans.ToLower() == "tails")
            {
                guess = 2;
            }

            //Assigning the random value to head or tail and outputing the answer to the console
            if (randomNum == 1)
            {
                coin = 1;
                Console.WriteLine("\nIt landed on heads.");
            }
            else
            {
                coin = 2;
                Console.WriteLine("\nIt landed on tails.");
            }

            //Checking if the guess and the random number is matching and if so output the result to the user
            if (guess == coin)
            {
                Console.WriteLine("You guessed correctly!");
            }
            else
            {
                Console.WriteLine("Better luck next time.");
            }

            //Outputing the developer of the program
            Console.WriteLine($"\nDeveloper: {developer}");
        }
    }
}
