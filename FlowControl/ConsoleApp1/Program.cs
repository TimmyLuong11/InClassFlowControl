using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer, name;
            int luckyNum, remainder;

            Console.WriteLine("Please enter your lucky # (while number) >>");
            answer = Console.ReadLine();
            //luckyNum = Convert.ToInt32(answer);
            //luckyNum = Convert.ToInt32(Console.ReadLine());
            bool isAnswerAInterger = int.TryParse(answer,out luckyNum);

            if (isAnswerAInterger == false)
            {
                Console.WriteLine("Sorry that was an invalid number, Goodbye.");
                //return;
                Environment.Exit(-1);
            }

            remainder = luckyNum % 7;

            if (remainder == 0)
            {
                Console.WriteLine($"{luckyNum.ToString("N0")} is really a lucky number!!");
            }
            else if (luckyNum % 13 == 0)
            {
                Console.WriteLine($"{luckyNum.ToString("N0")} is really a unlucky number! :(");
            }
            else
            { 
                Console.WriteLine($"meh.. {luckyNum.ToString("N0")}");
            }


            Console.WriteLine("What is your first name >>");
            name = Console.ReadLine();

            switch (name.ToLower())
            {
                case "adam":
                    Console.WriteLine("That's the coolest name ever!");
                    break;
                case "darby":
                    Console.WriteLine("That's a cool name, but nothing like Adam!");
                        break;
                default:
                    Console.WriteLine("Cool!");
                    break;
            }
        }
    }
}
