using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your lucky #>>");
            string answer = Console.ReadLine();
            int luckyNum;
            while (int.TryParse(answer, out luckyNum) == false)
            {
                Console.WriteLine("Sory ou enter an invalid #. Please try again");
                answer = Console.ReadLine();
                
            }
            Console.WriteLine("Yay you know how to enter in a number");
        }
    }
}
