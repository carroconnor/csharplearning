using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._23_MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior carr = new Warrior("Carr", 1000, 120, 40);

            Battle.StartFight(carr, bob);

            Console.ReadLine();

        
        }
    }
}
