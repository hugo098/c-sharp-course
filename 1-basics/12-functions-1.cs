using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {

        private static void SayHello()
        {
            // Defines a variable that will store a string
            // of characters
            string name = "";

            Console.Write("What is your name : ");

            // Save the input the user provides
            name = Console.ReadLine();

            Console.WriteLine("Hello {0}", name);
        }

        // If you assign a value then it is optional to
        // pass
        static double GetSum(double x = 1, double y = 1)
        {
            double temp = x;
            x = y;
            y = temp;
            return x + y;
        }

        static void Main(string[] args)
        {
            // ---------- FUNCTIONS / METHODS ----------
            // Functions are used to avoid code duplication, provides
            // organization and allows use to simulate different
            // systems
            // <Access Specifier> <Return Type> <Method Name>(Parameters)
            // { <Body> }

            // Access Specifier determines whether the function can
            // be called from another class
            // public : Can be accessed from another class
            // private : Can't be accessed from another class
            // protected : Can be accessed by class and derived classes

            SayHello();

            // ----- PASSING BY VALUE -----
            // By default values are passed into a method
            // and not a reference to the variable passed
            // Changes made to those values do not effect the
            // variables outside of the method
            double x = 5;
            double y = 4;

            Console.WriteLine("5 + 4 = {0}",
                GetSum(x, y));

            // Even though the value for x changed in
            // method it remains unchanged here
            Console.WriteLine("x = {0}",
                x);
        }
    }
}
