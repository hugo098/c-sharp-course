using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {

        static void Main(string[] args)
        {
            Animal cat = new Animal();
            cat.SetName("Whiskers");
            cat.Sound = "Meow";
            Console.WriteLine("The cat is name {0} and says {1}",
                cat.GetName(), cat.Sound);
            cat.Owner = "Hugo";
            Console.WriteLine("{0} owner is {1}",
                cat.GetName(), cat.Owner);
            Console.WriteLine("{0} shelter is {1}",
                cat.GetName(), cat.idNum);
            Console.WriteLine("# of animals is {0}",
                Animal.NumOfAnimals);


        }
    }
}
