using System;

namespace FlowControl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int var1 = 0;
            if (var1 ==1)
            {
                //Do something
            }
            else if (var1 == 2)
            {
                //do something
            }
            else if (var1 == 3 || var1 == 4)
            {
                //Do something
            }
            else
            {
                //Do something 
            }

            const string myName = "Benjamin";
            const string niceName = "Andrea";
            const string sillyName = "Ploppy";
            string name;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            switch(name.ToLower())
            {
                case myName:
                    Console.WriteLine("You have the same name as me!");
                    break;
                case niceName:
                    Console.WriteLine("My, what a nice name you have!");
                    break;
                case sillyName:
                    Console.WriteLine("That's a very silly name.");
                    break;
            }
            Console.WriteLine("That's a very silly name.");
            Console.ReadKey();

            int myInterger = 0;
            string resultString = (myInterger < 10) ? "Less than 10" : "Greather than or equal to 10";
        }
    }
}
