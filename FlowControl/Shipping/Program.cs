using System;

namespace Shipping
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight, distance, quote, cost, netTotal,total,discount =0;
            string answer;

            do
            {
                Console.WriteLine("Plaese enter the # of mile>>");
                answer = Console.ReadLine();
                bool isSuccessfull = double.TryParse(answer, out distance);
                if (isSuccessfull == false)
                {
                    Console.WriteLine("Invalid input. Goodbye.");
                    Environment.Exit(-1);
                }

                Console.WriteLine("Plaese enter the weight of your shipment (in lbs) >>");
                answer = Console.ReadLine();
                if (double.TryParse(answer, out weight) == false)
                {
                    Console.WriteLine("Invalid input. Goodbye.");
                    Environment.Exit(-1);
                }

                Console.WriteLine("Does your shipment contain hazordous maerials? Yes or No >>");
                answer= Console.ReadLine();
                quote = 0.55 * distance + 0.73 * weight;
                if(answer.ToLower() == "yes")
                {
                    cost = 0.015 * weight;
                }
                else
                {
                    cost = 0;
                }

                netTotal = quote + cost;

                if (distance < 150 && weight > 500)
                {
                    discount = 0.10 * netTotal;
                }
     
                total = netTotal - discount;
                Console.WriteLine($"Quote: \t\t{quote.ToString("C")}");
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine($"Hazardous Cost: {cost.ToString("C")}");
                Console.WriteLine($"Discount: \t{discount.ToString("C")}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Total: \t\t{total.ToString("C")}");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\nDo you want to enter another shipment? Yes or No >>");
                answer = Console.ReadLine();
                while (answer.ToLower() != "yes" && answer.ToLower() != "no")
                {
                    Console.WriteLine("YOU MUST ANSWER YES OR NO!");
                    answer = Console.ReadLine();
                }
            } while (answer.ToLower() == "yes");
            Console.WriteLine("\nGoodbye");
        }       
    }
}
