using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IElectronicDevice TV = TVRemote.GetDevice();

            PowerButton powerButton = new PowerButton(TV);

            powerButton.Execute();
            powerButton.Undo();
            powerButton.Execute();
            powerButton.Undo();
            
        }

    }
}