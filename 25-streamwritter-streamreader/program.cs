using System;
using System.Linq;

// Used for ArrayLists
using System.Collections;

// Used for Dictionary
using System.Collections.Generic;

// Used for file and directory
// manipulation
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----- STREAMWRITER / STREAMREADER -----
            // These are best for reading and writing strings

            string textFilePath3 = @"C:\Users\ASUS\testfile3.txt";

            // Create a text file
            StreamWriter sw = File.CreateText(textFilePath3);

            // Write to a file without a newline
            sw.Write("This is a random ");

            // Write to a file with a newline
            sw.WriteLine("sentence.");

            // Write another
            sw.WriteLine("This is another sentence.");

            // Close the StreamWriter
            sw.Close();

            // Open the file for reading
            StreamReader sr = File.OpenText(textFilePath3);

            // Peek returns the next character as a unicode
            // number. Use Convert to change to a character
            Console.WriteLine("Peek : {0}",
                Convert.ToChar(sr.Peek()));

            // Read to a newline
            Console.WriteLine("1st String : {0}",
                sr.ReadLine());

            // Read to the end of the file starting
            // where you left off reading
            Console.WriteLine("Everything : {0}",
                sr.ReadToEnd());

            sr.Close();
        }
    }     
}
