using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Multidimensional arrays        
            // If you define arrName[2,2] you are saying
            // you want to have 2 rows high and 2 across
            string[,] custNames = new string[2, 2] { { "Bob", "Smith" },
                { "Sally", "Smith" } };

            // Get value in MD array
            Console.WriteLine("MD Value : {0}",
                custNames.GetValue(1, 1));

            // Cycle through the multidimensional array
            // Get length of multidimensional array column
            for (int j = 0; j < custNames.GetLength(0); j++)
            {
                // Get length of multidimensional array row
                for (int k = 0; k < custNames.GetLength(1); k++)
                {
                    Console.Write("{0} ", custNames[j, k]);
                }
                Console.WriteLine();
            }

            // An array like arrName[2,2,3] would be like a
            // stack of 3 spread sheets with 2 rows and 2
            // columns worth of data on each page

        }
    }
}
