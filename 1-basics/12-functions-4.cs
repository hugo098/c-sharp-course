using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {

        // ----- METHOD OVERLOADING -----
        static double GetSum2(double x = 1, double y = 1)
        {
            return x + y;
        }

        static double GetSum2(string x = "1", string y = "1")
        {
            double dblX = Convert.ToDouble(x);
            double dblY = Convert.ToDouble(y);
            return dblX + dblY;
        }

        static void Main(string[] args)
        {
            // ----- METHOD OVERLOADING -----
            // You can define methods with the same
            // name that will be called depending on
            // what data is sent automatically
            Console.WriteLine("5.0 + 4.0 = {0}",
                GetSum2(5.0, 4.5));

            Console.WriteLine("5 + 4 = {0}",
                GetSum2(5, 4));

            Console.WriteLine("5 + 4 = {0}",
                GetSum2("5", "4"));

        }
    }
}
