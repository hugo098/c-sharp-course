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

        // ----- Lock Example -----
        // lock keeps other threads from entering 
        // a statement block until another thread
        // leaves
        static void Main(string[] args)
        {
            BankAcct acct = new BankAcct(10);
            Thread[] threads = new Thread[15];

            // CurrentThread gets you the current
            // executing thread
            Thread.CurrentThread.Name = "main";

            // Create 15 threads that will call for 
            // IssueWithdraw to execute
            for (int i = 0; i < 15; i++)
            {
                // You can only point at methods
                // without arguments and that return 
                // nothing
                Thread t = new Thread(new
                    ThreadStart(acct.IssueWithdraw));
                t.Name = i.ToString();
                threads[i] = t;
            }

            // Have threads try to execute
            for (int i = 0; i < 15; i++)
            {
                // Check if thread has started
                Console.WriteLine("Thread {0} Alive : {1}",
                    threads[i].Name, threads[i].IsAlive);

                // Start thread
                threads[i].Start();

                // Check if thread has started
                Console.WriteLine("Thread {0} Alive : {1}",
                    threads[i].Name, threads[i].IsAlive);
            }

            // Get thread priority (Normal Default)
            // Also Lowest, BelowNormal, AboveNormal
            // and Highest
            // Changin priority doesn't guarantee
            // the highest precedence though
            // It is best to not mess with this
            Console.WriteLine("Current Priority : {0}",
                Thread.CurrentThread.Priority);

            Console.WriteLine("Thread {0} Ending",
                Thread.CurrentThread.Name);

            Console.ReadLine();
        }
    }   
}
