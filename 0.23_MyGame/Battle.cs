using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._23_MyGame
{
    class Battle
    {
        //newthinktank.com/2017/02/c-tutorial-8/
        //StartFight
        //Warrior 1 Warrior2

        //Loop giving each warrior chance to attack n block each turn till death
        //GetAttackResult
        //WarriorA, WarriorB

        //Calc 1 warriors attack and others block

        //Subtract block from attack
        //if there is damage, sub damage from other
        //print out info on who attacked who

        //provide output on change in health

        //Check if warriors health fell below 0
        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            int warAAttkAmt = warriorA.Attack();
            int warBBlkAmt = warriorB.Block();

            int dmg2WarB = warAAttkAmt - warBBlkAmt;

            if(dmg2WarB > 0)
            {
                warriorB.Health = warriorB.Health - dmg2WarB;
            }
            else dmg2WarB = 0;
            
        }   

        public static void StartFight(Warrior
            warrior1, Warrior warrior2)
        {
            while (true)
            {
                if (GetAttackResult(warrior1, warrior2) == "Game Over");
                {
                    Console.WriteLine("Game Over");
                    break;
                }

                if (GetAttackResult(warrior2, warrior1) == "Game Over") ;
                {
                    Console.WriteLine("Game Over");
                    break;
                }

            }
            Console.WriteLine("{0} Has {1} Health");

            if (warrior2.Health <= 0)
            {
                Console.WriteLine("{0} has died and {1} is Victorius\n",
                    warrior2.Name,
                    warrior1.Name);
                return "Game Over";
            } else return "Fight Over";
            
        }
        
    }
}
