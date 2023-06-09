using System;
using System.Linq;

// Used for ArrayLists
using System.Collections;

// Used for Dictionary
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------- QUEUES ----------
            #region Queue Code
            // Queue 1st in 1st Out Collection

            // Create a Queue
            Queue queue = new Queue();

            // Add values
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            // Is item in queue
            Console.WriteLine("1 in Queue : {0}",
                queue.Contains(1));

            // Remove 1st item from queue
            Console.WriteLine("Remove 1 : {0}",
                queue.Dequeue());

            // Look at 1st item but don't remove
            Console.WriteLine("Peek 1 : {0}",
                queue.Peek());

            // Copy queue to array
            object[] numArray = queue.ToArray();

            // Print array
            Console.WriteLine(string.Join(",", numArray));

            // Print queue items
            foreach (object o in queue)
            {
                Console.WriteLine($"Queue : {o}");
            }

            // Clear the queue
            queue.Clear();


            #endregion

        }

    }
}