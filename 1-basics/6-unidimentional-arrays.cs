using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ------ ARRAYS ------

            // Define an array which holds 3 values
            // Arrays have fixed sizes
            int[] favNums = new int[3];

            // Add a value to the array
            favNums[0] = 23;

            // Retrieve a value
            Console.WriteLine("favNum 0 : {0}", favNums[0]);

            // Create and fill array
            string[] customers = { "Bob", "Sally", "Sue" };

            // You can use var to create arrays, but the
            // values must be of the same type
            var employees = new[] { "Mike", "Paul", "Rick" };

            // Create an array of base objects which is the
            // base type of all other types
            object[] randomArray = { "Paul", 45, 1.234 };

            // GetType knows its true type
            Console.WriteLine("randomArray 0 : {0}",
                randomArray[0].GetType());

            // Get number of items in array
            Console.WriteLine("Array Size : {0}",
                randomArray.Length);

            // Use for loop to cycle through the array
            for (int j = 0; j < randomArray.Length; j++)
            {
                Console.WriteLine("Array {0} : Value : {1}",
                j, randomArray[j]);
            }


        }
    }
}
