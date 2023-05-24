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
        delegate double doubleIt(double val);
        static void Main(string[] args)
        {
            // ---------- SELECT ----------
            // Select allows us to execute a function 
            // on each item in a list

            // Generate a list from 1 to 10
            var oneTo10 = new List<int>();
            oneTo10.AddRange(Enumerable.Range(1, 10));
            var squares = oneTo10.Select(x => x * x);
            foreach (var l in squares) Console.WriteLine(l);

            // ---------- ZIP ----------
            // Zip applies a function to two lists 
            // Add values in 2 lists together
            var listOne = new List<int>(new int[] { 1, 3, 4 });
            var listTwo = new List<int>(new int[] { 4, 6, 8 });

            var sumList = listOne.Zip(listTwo, (x, y) => x + y).ToList();

            foreach (var n in sumList)
                Console.WriteLine(n);
        }
    }
}