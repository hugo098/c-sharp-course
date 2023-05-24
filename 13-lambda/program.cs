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
            // Lambda expressions allow you to 
            // use anonymous methods that define
            // the input parameters on the left 
            // and the code to execute on the right

            // Assign a Lambda to the delegate
            doubleIt dblIt = x => x * 2;
            Console.WriteLine($"5 * 2 = {dblIt(5)}");


            // You don't have to use delegates though
            // Here we'll search through a list to 
            // find all the even numbers
            List<int> numList = new List<int> { 1, 9, 2, 6, 3 };

            // Put the number in the list if the 
            // condition is true
            var evenList = numList.Where(a => a % 2 == 0).ToList();
            foreach (var i in evenList) Console.WriteLine(i);

            // Add values in a range to a list
            var rangeList = numList.Where(x=> ( x > 2) || (x < 9)).ToList();
            foreach (var i in rangeList) Console.WriteLine(i);


            // Find the number of heads and tails in
            // a list 1 = H, 2 = T
            List<int> flipList = new List<int>();
            int j = 0;
            Random rnd = new Random();
            while(j < 100)
            {
                flipList.Add(rnd.Next(1, 3));
                j++;
            }
            Console.WriteLine("Heads : {0}",
                flipList.Where(a=> a==1).ToList().Count());
            Console.WriteLine("Tails : {0}",
                flipList.Where(a => a == 2).ToList().Count());

            // Find all names starting with s
            var nameList = new List<string>() { "Doug", "Sally", "Sue"};
            var sNameList = nameList.Where(x => x.StartsWith("S"));
            foreach (var s in sNameList) Console.WriteLine(s);
        }
    }
}