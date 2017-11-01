using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._19_MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Player class with
            //1 Attack() methods that accepts 3 different sets of parameters
            //for example
            //Attack(100) --> Attacked for 100!
            //Attack (100, "Weapon") --> Attacked with Weapon for 100
            //Attack(100, "Weapon", #ofTimes) --> Attacked with Weapon for 100 #ofTimes, dealing totalDamage

            Player me = new Player();
            me.Attack(2500);
            me.Attack(1000, "dusty stick");
            me.Attack(500, "Katana", 90);
            Console.WriteLine(me);
            Console.ReadLine();



        }
    }
}
