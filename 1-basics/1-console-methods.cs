using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {            
            // Prints Hello World on the console
            Console.WriteLine("Hello World!");
        
            // Console.ForegroundColor = ConsoleColor.Black;
            // Console.BackgroundColor = ConsoleColor.White;
            // Console.Clear();

            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
        }
    }
}
