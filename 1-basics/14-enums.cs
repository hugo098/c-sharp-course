using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {

        static void PaintCar(CarColor cc)
        {
            Console.WriteLine("The car was painted {0} with the code {1}",
                cc, (int)cc);
        }

        // ------ ENUMS ------
        // An enum is a custom data type with
        // key value pairs. They allow you to
        // use symbolic names to represent data
        // The first number is 0 by default unless
        // you change it
        // You can define the underlying type
        // or leave it as int as default

        enum CarColor : byte
        {
            Orange = 1,
            Blue,
            Green,
            Red,
            Yellow
        }
        static void Main(string[] args)
        {
            // ----- ENUM -----
            CarColor car1 = CarColor.Blue;
            PaintCar(car1);

            // Waits for input from the user if you run the
            // ConsoleApp1.exe instead of instantly closing
            // The executable is in bin/Debug/net6.0
            Console.Read();

        }
    }
}
