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
            // ---------- AGGREGATE ----------
            // Aggregate performs an operation on 
            // each item in a list and carries the 
            // results forward 

            // Sum values in a list
            var numList2 = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine("Sum : {0}",
                numList2.Aggregate((a, b) => a + b));

            // ---------- AVERAGE ----------
            // Get the average of a list of values
            var numList3 = new List<int>() { 1, 2, 3, 4, 5 };

            // AsQueryable allows you to manipulate the
            // collection with the Average function
            Console.WriteLine("AVG : {0}",
                numList3.AsQueryable().Average());

            // ---------- ALL ----------
            // Determines if all items in a list
            // meet a condition
            var numList4 = new List<int>() { 1, 2, 3, 4, 5 };

            Console.WriteLine("All > 3 : {0}",
                numList4.All(x => x > 3));

            // ---------- ANY ----------
            // Determines if any items in a list
            // meet a condition
            var numList5 = new List<int>() { 1, 2, 3, 4, 5 };

            Console.WriteLine("Any > 3 : {0}",
                numList5.Any(x => x > 3));

            // ---------- DISTINCT ----------
            // Eliminates duplicates from a list
            var numList6 = new List<int>() { 1, 2, 3, 2, 3 };

            Console.WriteLine("Distinct : {0}",
                string.Join(", ", numList6.Distinct()));

            // ---------- EXCEPT ----------
            // Receives 2 lists and returns values not
            // found in the 2nd list
            var numList7 = new List<int>() { 1, 2, 3, 2, 3 };
            var numList8 = new List<int>() { 3 };

            Console.WriteLine("Except : {0}",
                string.Join(", ", numList7.Except(numList8)));

            // ---------- INTERSECT ----------
            // Receives 2 lists and returns values that
            // both lists have
            var numList9 = new List<int>() { 1, 2, 3, 2, 3 };
            var numList10 = new List<int>() { 2, 3 };

            Console.WriteLine("Intersect : {0}",
                string.Join(", ", numList9.Intersect(numList10)));
        }
    }
}