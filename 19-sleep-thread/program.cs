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

        // ----- Sleep Example -----

        // With sleep() the thread is suspended
        // for the designated amount of time
        static void Main(string[] args)
        {
            int num = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(num);

                // Pause for 1 second
                Thread.Sleep(1000);

                num++;
            }

            Console.WriteLine("Thread Ends");

            Console.ReadLine();
        }
    }
}
