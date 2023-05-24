using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {

        static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }

        // ----- PASS BY REFERENCE -----
        // If a variable is passed by reference changes
        // to its value in the method effect it outside
        // of the method
        public static void Swap(ref int num3, ref int num4)
        {
            int temp = num3;
            num3 = num4;
            num4 = temp;
        }



        static void Main(string[] args)
        {
            // ----- OUT PARAMETER -----
            // You can pass a variable as an output
            // variable even without assigning a
            // value to it
            int solution;

            // A parameter passed with out has its
            // value assigned in the method
            DoubleIt(15, out solution);

            Console.WriteLine("15 * 2 = {0}",
                solution);

            // ----- PASS BY REFERENCE -----
            int num3 = 10;
            int num4 = 20;

            Console.WriteLine("Before Swap num1 : {0} num2 : {1}", num3, num4);

            Swap(ref num3, ref num4);

            Console.WriteLine("After Swap num1 : {0} num2 : {1}", num3, num4);

        }
    }
}
