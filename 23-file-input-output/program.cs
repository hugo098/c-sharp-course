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
            // ----- SIMPLE FILE READING & WRITING -----

            // Write a string array to a text file
            string[] customers =
            {
                "Bob Smith",
                "Sally Smith",
                "Robert Smith"
            };

            string textFilePath = @"C:\Users\ASUS\testfile1.txt";
            ;
            // Write the array
            File.WriteAllLines(textFilePath,
                customers);

            // Read strings from array
            foreach (string cust in File.ReadAllLines(textFilePath))
            {
                Console.WriteLine($"Customer : {cust}");
            }

            // ----- GETTING FILE DATA -----

            DirectoryInfo myDataDir = new DirectoryInfo(@"C:\Users\ASUS\");

            // Get all txt files 
            FileInfo[] txtFiles = myDataDir.GetFiles("*.txt",
                SearchOption.TopDirectoryOnly);

            // Number of matches
            Console.WriteLine("Matches : {0}",
                txtFiles.Length);

            foreach (FileInfo file in txtFiles)
            {
                // Get file name
                Console.WriteLine(file.Name);

                // Get bytes in file
                Console.WriteLine(file.Length);
            }
        }
    }     
}
