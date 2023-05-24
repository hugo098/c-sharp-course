using System;
using System.Linq;

// Used for ArrayLists
using System.Collections;

// Used for Dictionary
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {


        static void Main(string[] args)
        {
            // ----- MESSING WITH DIRECTORIES -----

            // Get access to the current directory
            DirectoryInfo currDir = new DirectoryInfo(".");

            // Get access to a directory with a path
            DirectoryInfo dereksDir = new DirectoryInfo(@"C:\Users\");

            // Get the directory path
            Console.WriteLine(dereksDir.FullName);

            // Get the directory name
            Console.WriteLine(dereksDir.Name);

            // Get the parent directory
            Console.WriteLine(dereksDir.Parent);

            // What type is it
            Console.WriteLine(dereksDir.Attributes);

            // When was it created
            Console.WriteLine(dereksDir.CreationTime);

            // Create a directory
            /* DirectoryInfo dataDir = new DirectoryInfo(@"C:\Users\ASUS\C#Data");
             dataDir.Create();*/

            // Delete a directory
            // Directory.Delete(@"C:\Users\ASUS\C#Data");

        }

    }

       
      
}
