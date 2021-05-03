using System;

namespace DotNet5DummyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing .Net5 Project!");
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
