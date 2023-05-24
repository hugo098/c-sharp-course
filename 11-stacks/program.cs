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
            // ---------- STACKS ----------
            #region Queue Code
            // Stack Last in 1st Out Collection

            // Create a stack
            Stack stack = new Stack();

            // Put items on the stack
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // Get but don't remove item
            Console.WriteLine("Peek 1 : {0}",
                stack.Peek());

            // Remove item
            Console.WriteLine("Pop 1 : {0}",
                stack.Pop());

            // Does item exist on stack
            Console.WriteLine("Contain 1 : {0}",
                stack.Contains(1));

            // Copy stack to array
            object[] numArray2 = stack.ToArray();

            // Print array
            Console.WriteLine(string.Join(",", numArray2));

            // Print the stack
            foreach (object o in stack)
            {
                Console.WriteLine($"Stack : {o}");
            }
            #endregion

        }

    }
}