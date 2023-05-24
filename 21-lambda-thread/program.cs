using System;
using System.Linq;

// Used for ArrayLists
using System.Collections;

// Used for Dictionary
using System.Collections.Generic;

namespace ConsoleApp1
{
    // With threads you can execute multiple
    // pieces of code that share resources
    // and data without corrupting it

    // You can't guarantee when a thread
    // executes. You also must lock resources
    // until a thread is done with them
    // or you could corrupt them

    class Program
    {

        // ----- Passing Data to Threads -----
        // You can pass arguments to a thread 
        // using a lambda expression

        static void Main(string[] args)
        {
            Thread t = new Thread(() => CountTo(10));
            t.Start();

            // You can use multiline lambdas
            new Thread(() =>
            {
                CountTo(5);
                CountTo(6);
            }).Start();

            Console.ReadLine();
        }

        static void CountTo(int maxNum)
        {
            for (int i = 0; i <= maxNum; i++)
            {
                Console.WriteLine(i);
            }
        }

    }

       
      
}
