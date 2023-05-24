using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Battle
    {
        public static void StartFight(Warrior warrior1,Warrior warrior2)
        {
            while (true){
                if (GetAttackResult(warrior1, warrior2) == "Game over")
                {
                    Console.WriteLine("Game over");
                    break;
                }

                if (GetAttackResult(warrior2, warrior1) == "Game over")
                {
                    Console.WriteLine("Game over");
                    break;
                }
            }
            
        }

        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            double warAAttakAmt = warriorA.Attack();
            double warBBlockAmt = warriorB.Block();

            double dmg2WarB = warAAttakAmt - warBBlockAmt;

            if (dmg2WarB > 0)
            {
                warriorB.Health = warriorB.Health - dmg2WarB;
            }
            else dmg2WarB = 0;

            Console.WriteLine("{0} Attacks {1} and Deals {2} Damage",
                warriorA.Name,
                warriorB.Name,
                dmg2WarB);

            Console.WriteLine("{0} has {1} Health\n",
                warriorB.Name,
                warriorB.Health);

            if (warriorB.Health <= 0)
            {
                Console.WriteLine("{0} has Died an {1} is the winner",
                    warriorB.Name,
                    warriorA.Name,
                    dmg2WarB);

                return "Game over";
            } else return "Fight Again";




        }

    }
}
