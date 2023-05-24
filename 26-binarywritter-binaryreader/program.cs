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
            // ----- BINARYWRITER / BINARYREADER -----
            // Used to read and write data types 
            string textFilePath4 = @"C:\Users\ASUS\testfile4.dat";

            // Get the file
            FileInfo datFile = new FileInfo(textFilePath4);

            // Open the file
            BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());

            // Data to save to the file
            string randText = "Random Text";
            int myAge = 42;
            double height = 6.25;

            // Write data to a file
            bw.Write(randText);
            bw.Write(myAge);
            bw.Write(height);

            bw.Close();

            // Open file for reading
            BinaryReader br = new BinaryReader(datFile.OpenRead());

            // Output data
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadDouble());

            br.Close();
        }
    }     
}
