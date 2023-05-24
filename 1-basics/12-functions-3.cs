using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {
        static double GetSumMore(params double[] nums)
        {
            double sum = 0;
            foreach (int i in nums)
            {
                sum += i;
            }
            return sum;
        }

        // ----- NAMED PARAMETERS -----
        static void PrintInfo(string name, int zipCode)
        {
            Console.WriteLine("{0} lives in the zip code {1}", name, zipCode);
        }

        static void Main(string[] args)
        {
            // ----- PARAMS -----
            // You are able to pass a variable amount
            // of data of the same data type into a
            // method using params. You can also pass
            // in an array.
            Console.WriteLine("1 + 2 + 3 = {0}",
                GetSumMore(1, 2, 3));


            // ----- NAMED PARAMETERS -----
            // You can pass values in any order if
            // you used named parameters
            PrintInfo(zipCode: 15147,
                name: "Derek Banas");

        }
    }
}
