using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {

            // ----- WHILE LOOP -----
            // You use the while loop when you want to execute
            // as long as a condition is true

            // This while loop will print odd numbers between
            // 1 and 10
            int i = 1;
            while (i <= 10)
            {
                // % (Modulus) returns the remainder of a
                // division. If it returns 0 that means the
                // value is even
                if (i % 2 == 0)
                {
                    i++;

                    // Continue skips the rest of the code and
                    // starts execution back at the top of the
                    // while
                    continue;
                }

                // Break jumps completely out of the loop
                if (i == 9) break;

                Console.WriteLine(i);
                i++;
            }

            // ----- DO WHILE LOOP -----
            // Use do while when you must execute the code
            // at least once

            // Generate a random number
            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 11);
            int numberGuessed = 0;
            // Console.WriteLine("Random Num : ", secretNumber);

            do
            {
                Console.Write("Enter a number between 1 & 10 : ");

                // Use Convert to switch the string into an int
                // Other Convert options : ToBoolean, ToByte,
                // ToChar, ToDecimal, ToDouble, ToInt64,
                // ToString, and they can convert from any
                // type to any other type
                numberGuessed = Convert.ToInt32(Console.ReadLine());

            } while (secretNumber != numberGuessed);

            Console.WriteLine("You guessed it is was {0}",
                secretNumber);

        }
    }
}
