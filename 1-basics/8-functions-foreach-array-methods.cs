using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void PrintArray(int[] intArray, string mess)
        {
            foreach (int k in intArray)
            {
                Console.WriteLine("{0} : {1} ", mess, k);
            }
            Console.WriteLine("---------------");
        }

        static void Main(string[] args)
        {
            // foreach can be used to cycle through an array
            int[] randNums = { 1, 4, 9, 2 };

            // You can pass an array to a function
            PrintArray(randNums, "ForEach");

            // Sort array
            Array.Sort(randNums);
            PrintArray(randNums, "ForEach");

            // Reverse array
            Array.Reverse(randNums);
            PrintArray(randNums, "ForEach");

            // Get index of match or return -1
            Console.WriteLine("1 at index : {0} ",
                Array.IndexOf(randNums, 1));

            // Change value at index 1 to 0
            randNums.SetValue(0, 1);
            PrintArray(randNums, "ForEach");

            // Copy part of an array to another
            int[] srcArray = { 1, 2, 3 };
            int[] destArray = new int[2];
            int startInd = 0;
            int length = 2;

            Array.Copy(srcArray, startInd, destArray,
                startInd, length);

            PrintArray(destArray, "Copy");

            // Create an array with CreateInstance
            Array anotherArray = Array.CreateInstance(typeof(int), 10);

            // Copy values in srcArray to destArray starting
            // at index 5 in destination
            srcArray.CopyTo(anotherArray, 5);

            foreach (int m in anotherArray)
            {
                Console.WriteLine("CopyTo : {0} ", m);
            }

        }
    }
}
