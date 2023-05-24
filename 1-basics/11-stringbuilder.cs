using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {

         static void Main(string[] args)
        {
            // ----- STRINGBUILDER -----
            // Each time you change a string you are actually
            // creating a new string which is inefficient
            // when you are working with large blocks of text
            // StringBuilders actually change the text
            // rather then make a copy

            // Create a StringBuilder with a default size
            // of 16 characters, but it grows automatically
            StringBuilder sb = new StringBuilder("Random Text");

            // Create a StringBuilder with a size of 256
            StringBuilder sb2 = new StringBuilder("More Stuff that is very important", 256);

            // Get max size
            Console.WriteLine("Capacity : {0}", sb2.Capacity);

            // Get length
            Console.WriteLine("Length : {0}", sb2.Length);

            // Add text to StringBuilder
            sb2.AppendLine("\nMore important text");

            // Define culture specific formating
            CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");

            // Append a format string
            string bestCust = "Bob Smith";
            sb2.AppendFormat(enUS, "Best Customer : {0}", bestCust);

            // Output StringBuilder
            Console.WriteLine(sb2.ToString());

            // Replace a string
            sb2.Replace("text", "characters");
            Console.WriteLine(sb2.ToString());

            // Clear a string builder
            sb2.Clear();

            sb2.Append("Random Text");

            // Are objects equal
            Console.WriteLine(sb.Equals(sb2));

            // Insert at an index
            sb2.Insert(11, " that's Great");

            Console.WriteLine("Insert : {0}", sb2.ToString());

            // Remove number of characters starting at index
            sb2.Remove(11, 7);

            Console.WriteLine("Remove : {0}", sb2.ToString());

        }
    }
}
