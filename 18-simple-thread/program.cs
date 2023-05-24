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

        // ----- Simple Thread Example -----
        static void Main(string[] args)
        {
            // We will randomly print 1 or 0
            // Create a thread and start it
            Thread t = new Thread(Print1);
            t.Start();

            // This code will run randomly
            for (int i = 0; i < 1000; i++)
                Console.Write(0);

            Console.ReadLine();

        }

        static void Print1()
        {
            for (int i = 0; i < 1000; i++)
                Console.Write(1);
        }
    }
}
