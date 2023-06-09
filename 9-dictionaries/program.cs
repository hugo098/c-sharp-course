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
            // ---------- DICTIONARIES ----------
            #region Dictionary Code

            // Dictionaries store key value pairs
            // To create them define the data
            // type for the key and the value
            Dictionary<string, string> superheroes = new Dictionary<string, string>();

            superheroes.Add("Clark Kent", "Superman");
            superheroes.Add("Bruce Wayne", "Batman");
            superheroes.Add("Barry West", "Flash");

            // Remove a key / value
            superheroes.Remove("Barry West");

            // Number of keys
            Console.WriteLine("Count : {0}",
                superheroes.Count);

            // Check if a key is present
            Console.WriteLine("Clark Kent : {0}",
                superheroes.ContainsKey("Clark Kent"));

            // Get the value for the key and store it
            // in a string

            superheroes.TryGetValue("Clark Kent", out string test);

            Console.WriteLine($"Clark Kent : {test}");

            // Cycle through key value pairs
            foreach (KeyValuePair<string, string> item in superheroes)
            {
                Console.WriteLine("{0} : {1}",
                    item.Key,
                    item.Value);
            }

            // Clear a dictionary
            superheroes.Clear();


            #endregion

        }

    }
}