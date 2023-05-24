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
            // ----- FILESTREAMS -----
            // FileStream is used to read and write a byte
            // or an array of bytes. 

            string textFilePath2 = @"C:\Users\ASUS\testfile2.txt";

            // Create and open a file
            FileStream fs = File.Open(textFilePath2,
                FileMode.Create);

            string randString = "This is a random string";

            // Convert to a byte array
            byte[] rsByteArray = Encoding.Default.GetBytes(randString);

            // Write to file by defining the byte array,
            // the index to start writing from and length
            fs.Write(rsByteArray, 0,
                rsByteArray.Length);

            // Move back to the beginning of the file
            fs.Position = 0;

            // Create byte array to hold file data
            byte[] fileByteArray = new byte[rsByteArray.Length];

            // Put bytes in array
            for (int i = 0; i < rsByteArray.Length; i++)
            {
                fileByteArray[i] = (byte)fs.ReadByte();
            }

            // Convert from bytes to string and output
            Console.WriteLine(Encoding.Default.GetString(fileByteArray));

            // Close the FileStream
            fs.Close();
        }
    }     
}
